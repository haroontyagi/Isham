using Microsoft.AspNetCore.Mvc;
using Invoicebook.Models;
using Invoicebook.Data;
using System.Linq;

namespace Invoicebook.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Client
        public IActionResult Index()
        {
            var clients = _context.Clients.ToList();
            return View(clients);
        }

        // GET: /Client/Edit/5
        public IActionResult Edit(int id)
        {
            var client = _context.Clients.FirstOrDefault(c => c.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: /Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Client model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var client = _context.Clients.FirstOrDefault(c => c.Id == id);
                if (client == null)
                {
                    return NotFound();
                }

                // Update fields
                _context.Entry(client).CurrentValues.SetValues(model);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
