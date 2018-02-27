using Arteg.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;

namespace Arteg.Controllers
{
    [Route("en")]
    public class EnglishController : Controller
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
        public IActionResult Atreg([FromForm]ContactMessage message)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using(var mail = new MailMessage(message.EmailAddress, "deaktamas93@gmail.com"))
                    {
                        mail.To.Add(new MailAddress("deaktamas93@gmail.com"));
                        mail.From = new MailAddress(message.EmailAddress);
                        mail.Subject = "Contact message from Atreg website";
                        mail.Body = ($"Name: {message.Name}; Subject: {message.Subject}; Email: {message.EmailAddress}; Text: {message.Text}");
                        //TODO: polish the text message of the mail
                        using(var client = new SmtpClient("smtp.gmail.com", 587))
                        {
                            client.EnableSsl = true;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential("atreg.info@gmail.com", "atreg2k18");
                            client.Timeout = 20000;

                            client.Send(mail);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }
            return View("Atreg");
        }
    }
}
