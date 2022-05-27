using System.Threading.Tasks;
using LoginWithIdentityPractices.Infrastructure.Identity.Models.Authentication;

namespace LoginWithIdentityPractices.Infrastructure.Identity.Services
{
    public interface IAuthenticateService
    {
        Task<AuthResponse> Authentcation(string email, string password);
    }
}
