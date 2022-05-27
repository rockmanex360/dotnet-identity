using System.Threading.Tasks;
using LoginWithIdentityPractices.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace LoginWithIdentityPractices.Infrastructure.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static void EnsureDatabaseCreated(this IApplicationBuilder builder)
        {
            using var serviceScope = builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            var services = serviceScope.ServiceProvider;
            var dbcontext = services.GetRequiredService<ApplicationDbContext>();

            dbcontext.Database.EnsureCreated();
        }

        public static async Task SeedIdentityDataAsync(this IApplicationBuilder builder)
        {
            using var serviceScope = builder.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();

            var service = serviceScope.ServiceProvider;

            var userManager = service.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();

            await Identity.Seed.DbContextDataSeed.SeedAsync(userManager, roleManager);
        }
    }
}
