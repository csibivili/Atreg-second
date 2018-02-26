using Arteg.Models;
using Microsoft.AspNetCore.Mvc;

namespace Arteg.Controllers
{
    [Route("it")]
    public class ItalianController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult IndexItalian()
        {
            return View("IndexItalian");
        }

        [HttpGet, Route("asianvital")]
        public IActionResult AsianVitalItalian()
        {
            return View("AsianVitalItalian");
        }

        [HttpGet, Route("atreg")]
        public IActionResult AtregItalian()
        {
            return View("AtregItalian");
        }

        [HttpPost, Route("atreg")]
        public IActionResult AtregItalian([FromBody] ContactMessage message)
        {
            return View("AtregItalian");
        }
    }
}
