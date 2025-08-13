using Microsoft.AspNetCore.Mvc;

namespace Invoicebook.Controllers
{
    public class InboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
