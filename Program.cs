using Serilog;
using Invoicebook.Data;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// ✅ Connection String from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// ✅ MySQL DbContext Register
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// ✅ Unique Log File Name
var uniqueLogId = Guid.NewGuid();
var logFilePath = $"App_Data/log_{uniqueLogId}.txt";

// ✅ Serilog Configuration
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File(logFilePath)
    .Enrich.FromLogContext()
    .CreateLogger();

builder.Host.UseSerilog();

// ✅ MVC Controllers with Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ✅ Exception Handling
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// ✅ Global Exception Logging Middleware
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Unhandled exception caught in middleware.");
        throw;
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

// ✅ Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
