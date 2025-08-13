using Microsoft.AspNetCore.Mvc;

namespace Invoicebook.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
