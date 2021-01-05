using System.Threading.Tasks;
using API.Entities;

namespace DatingApp.API.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}