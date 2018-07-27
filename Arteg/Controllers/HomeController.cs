using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToActionPermanent("Index", "English");
        }

        [HttpGet("google925c7cc039ea380c")]
        public IActionResult Certificate()
        {
            return View("google925c7cc039ea380c");
        }
    }
}
