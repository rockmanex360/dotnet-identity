using System.Threading.Tasks;
using LoginWithIdentityPractices.Infrastructure.Identity.Models.Authentication;
using LoginWithIdentityPractices.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginWithIdentityPractices.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticateService _authService;

        public AccountController(IAuthenticateService authService)
        {
            _authService = authService;
        }

        [HttpPost("Auth")]
        public async Task<IActionResult> AuthenticateAsync([FromBody] AuthRequest request)
        {
            var data = await _authService.Authentcation(request.Email, request.Password);
            return Ok(data);
        }
            
    }
}
