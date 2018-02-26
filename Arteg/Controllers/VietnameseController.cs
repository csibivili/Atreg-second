using Arteg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    [Route("it")]
    public class VietnameseController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult IndexVietnamese()
        {
            return View("IndexVietnamese");
        }

        [HttpGet, Route("asianvital")]
        public IActionResult AsianVitalVietnamese()
        {
            return View("AsianVitalVietnamese");
        }

        [HttpGet, Route("atreg")]
        public IActionResult AtregVietnamese()
        {
            return View("AtregVietnamese");
        }

        [HttpPost, Route("atreg")]
        public IActionResult AtregVietnamese([FromBody] ContactMessage message)
        {
            return View("AtregVietnamese");
        }
    }
}
