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
            return View($"Index");
        }

        [HttpGet("asianvital")]
        public IActionResult AsianVital()
        {
            return View($"AsianVital");
        }

        [HttpGet("atreg")]
        public IActionResult Atreg()
        {
            return View($"Atreg");
        }

        [HttpPost("atreg")]
        public async Task<IActionResult> Atreg([FromForm]ContactMessage message)
        {
            await _service.SendMail(message);
            return View("Atreg");
        }
    }
}
