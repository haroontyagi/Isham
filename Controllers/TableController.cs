using Microsoft.AspNetCore.Mvc;

namespace Invoicebook.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
