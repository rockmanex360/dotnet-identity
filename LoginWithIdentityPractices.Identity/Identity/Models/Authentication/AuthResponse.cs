using System;
namespace LoginWithIdentityPractices.Infrastructure.Identity.Models.Authentication
{
    public class AuthResponse
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
