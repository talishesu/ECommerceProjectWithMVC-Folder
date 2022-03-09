using ECommerceProjectWithMVC.Models.Entities.Membership;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceProjectWithMVC.Models.DataContexts
{
    static public class ShopDbSeed
    {
        const string adminEmail = "talishesu@gmail.com";
        const string adminPassword = "Talishesu107";
        const string superAdminName = "SuperAdmin";
        static internal IApplicationBuilder SeedMemberShip(this IApplicationBuilder builder)
        {
            using (var scope = builder.ApplicationServices.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ShopDbContext>();

                db.Database.Migrate();

                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ShopRole>>();

                var role = roleManager.FindByNameAsync(superAdminName).Result;
                if(role == null)
                {
                    role = new ShopRole
                    {
                        Name = superAdminName
                    };

                    roleManager.CreateAsync(role).Wait();
                }




                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ShopUser>>();

                var adminUser = userManager.FindByEmailAsync(adminEmail).Result;
                if (adminUser == null)
                {
                    adminUser = new ShopUser
                    {
                        Email = adminEmail,
                        UserName = adminEmail,
                        EmailConfirmed = true,
                        Name = "Admin",
                        Surname="Admin"
                    };

                    var userResult = userManager.CreateAsync(adminUser, adminPassword).Result;

                    if(userResult.Succeeded)
                    {
                        userManager.AddToRoleAsync(adminUser,superAdminName).Wait();
                    }

                }

            }


            return builder;
        }
    }
}
