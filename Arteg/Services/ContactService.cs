using Arteg.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Arteg.Services
{
    public class ContactService : IContactService
    {
        private const string _userName = "atreg.info@gmail.com";
        private const string _password = "atreg2k18";

        public async Task SendMail(ContactMessage message)
        {
            try
            {
                #region html message composition
                StringBuilder mailBody = new StringBuilder()
                  .Append
                  (
                    $"<html><head></head><body>" +
                    $"<span style =\"font-weight:bold\">" +
                    $"From:</span><br />" +
                    $"<span>{ message.Name}</span><br />" +
                    $"<span>{ message.EmailAddress}</span><br /><br />" +
                    $"<span style =\"font-weight:bold\">" +
                    $"Subject:</span><br />" +
                    $"<span>{ message.Subject}</span><br /><br />" +
                    $"<span style =\"font-weight:bold\">" +
                    $"Text:</span><br />" +
                    $"<span>{ message.Text}</span></body></html>"
                  );
                #endregion

                using (var mail = new MailMessage(message.EmailAddress, "info@atregconsulting.com"))
                {
                    mail.Subject = $"Message from {message.EmailAddress} on the Atreg website";
                    mail.IsBodyHtml = true;
                    mail.Body = mailBody.ToString();

                    #region smtp configuration
                    using (var client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential(_userName, _password);
                        client.Timeout = 20000;

                        await client.SendMailAsync(mail);
                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
