using MiniV2.Models;
using System.Threading.Tasks;

namespace MiniV2.Core
{
    public interface IEmail
    {
        Task SendAsync(Contato contato);
    }
}