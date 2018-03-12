using Arteg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    [Route("vn")]
    public class VietnameseController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("asianvital")]
        public IActionResult AsianVital()
        {
            return View("AsianVital");
        }

        [HttpGet("atreg")]
        public IActionResult Atreg()
        {
            return View("Atreg");
        }

        [HttpPost("atreg")]
        public IActionResult Atreg([FromBody] ContactMessage message)
        {
            return View("Atreg");
        }
    }
}
