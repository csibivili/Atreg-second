using Arteg.Models;
using System.Threading.Tasks;

namespace Arteg.Services
{
    public interface IContactService
    {
        Task SendMail(ContactMessage message);
    }
}
