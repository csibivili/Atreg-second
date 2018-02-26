using System;

namespace Arteg.Models
{
    public class ContactMessage
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime SentDateTime { get; set; }
    }
}
