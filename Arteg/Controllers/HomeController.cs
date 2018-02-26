using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AsianVital()
        {
            return View();
        }

        public IActionResult Atreg()
        {
            return View();
        }
    }
}
