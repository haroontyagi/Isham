using Microsoft.AspNetCore.Mvc;

namespace Invoicebook.Controllers
{
    public class ReadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
