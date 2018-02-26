using Arteg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    [Route("en")]
    public class EnglishController : Controller
    {
        [HttpGet("")]
        public IActionResult IndexEnglish()
        {
            return View("IndexEnglish");
        }

        [HttpGet("asianvital")]
        public IActionResult AsianVitalEnglish()
        {
            return View("AsianVitalEnglish");
        }

        [HttpGet("atreg")]
        public IActionResult AtregEnglish()
        {
            return View("AtregEnglish");
        }

        [HttpPost("atreg")]
        public IActionResult AtregEnglish([FromBody] ContactMessage contactMessage)
        {
            return View("AtregEnglish");
        }
    }
}
