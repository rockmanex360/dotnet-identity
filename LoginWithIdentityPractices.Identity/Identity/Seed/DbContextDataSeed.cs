using System;
using System.Threading.Tasks;
using LoginWithIdentityPractices.Core.Constants;
using LoginWithIdentityPractices.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LoginWithIdentityPractices.Infrastructure.Identity.Seed
{
    public static class DbContextDataSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(ApplicationIdentityConstants.Role.Administrator));
            await roleManager.CreateAsync(new IdentityRole(ApplicationIdentityConstants.Role.User));

            var adminEmail = "admin@administrator.com";
            var adminUser = new ApplicationUser
            {
                UserName = "admin",
                Email = adminEmail,
                FirstName = "Admin",
                LastName = "Administrator",
                EmailConfirmed = true,
            };

            await userManager.CreateAsync(adminUser, ApplicationIdentityConstants.DefaultPassword);
            adminUser = await userManager.FindByEmailAsync(adminEmail);

            await userManager.AddToRoleAsync(adminUser, ApplicationIdentityConstants.Role.Administrator);
        }
    }
}
