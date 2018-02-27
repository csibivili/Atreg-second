using System;
using System.ComponentModel.DataAnnotations;

namespace Arteg.Models
{
    public class ContactMessage
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Text { get; set; }
    }
}
