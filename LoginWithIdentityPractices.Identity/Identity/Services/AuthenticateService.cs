using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginWithIdentityPractices.Infrastructure.Identity.Models;
using LoginWithIdentityPractices.Infrastructure.Identity.Models.Authentication;
using Microsoft.AspNetCore.Identity;

namespace LoginWithIdentityPractices.Infrastructure.Identity.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthenticateService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<AuthResponse> Authentcation(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                throw new KeyNotFoundException();

            var signInResult = await _signInManager.PasswordSignInAsync(user, password, true, false);

            if (!signInResult.Succeeded)
                throw new Exception("Failed to login");

            var role = (await _userManager.GetRolesAsync(user)).FirstOrDefault() ?? "Basic";

            await _userManager.UpdateAsync(user);

            return new AuthResponse
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Role = role,
                Token = "example"
            };
        }
    }
}
