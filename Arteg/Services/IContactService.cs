using Arteg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arteg.Services
{
    public interface IContactService
    {
        Task SendMail(ContactMessage message);
    }
}
