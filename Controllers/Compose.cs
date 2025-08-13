using Microsoft.AspNetCore.Mvc;

namespace Invoicebook.Controllers
{
    public class ComposeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
