using ECommerceProjectWithMVC.AppCode.Providers;
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
        const string sellerName = "Seller";
        static string[] claimsForSeller = { "admin.dashboard.index", "admin.orders.index", "admin.orders.edit", "admin.products.index", "admin.products.detail", "admin.products.create", "admin.products.edit", "admin.products.delete", "admin.products.reverse" };
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





                var role2 = roleManager.FindByNameAsync(sellerName).Result;
                if (role2 == null)
                {
                    role2 = new ShopRole
                    {
                        Name = sellerName
                    };

                    roleManager.CreateAsync(role2).Wait();

                    foreach (var item in claimsForSeller)
                    {
                        var roleClaims = new ShopRoleClaim
                        {
                            RoleId = role2.Id,
                            ClaimType = item,
                            ClaimValue = "1"
                        };
                        db.RoleClaims.AddAsync(roleClaims);
                    }
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
