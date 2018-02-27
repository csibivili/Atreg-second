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
    }
}
