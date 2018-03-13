using Arteg.Models;
using Arteg.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Arteg.Controllers
{
    [Route("en")]
    public class EnglishController : Controller
    {
        IContactService _service;

        public EnglishController(IContactService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Title = "Atreg & Asian Vital";

            return View($"Index");
        }

        [HttpGet("asianvital")]
        public IActionResult AsianVital()
        {
            ViewBag.Title = "Asian Vital";

            return View($"AsianVital");
        }

        [HttpGet("atreg")]
        public IActionResult Atreg()
        {
            ViewBag.Title = "Atreg";

            return View($"Atreg");
        }

        [HttpPost("atreg")]
        public async Task<IActionResult> Atreg([FromForm]ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                await _service.SendMail(message);
                ViewData["Message"] = "Success";
                return View($"Atreg");
            }
            ViewData["Message"] = "Fail";
            return LocalRedirect("/en/atreg#contactForm");
        }
    }
}
