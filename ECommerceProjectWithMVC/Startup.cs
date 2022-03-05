using ECommerceProjectWithMVC.AppCode.Providers;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProjectWithMVC
{
    public class Startup
    {
        readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(cfg =>
            {
                cfg.ModelBinderProviders.Insert(0, new BooleanBinderProvider());

                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();

                cfg.Filters.Add(new AuthorizeFilter(policy));
            });
            services.AddRouting(cfg =>
            {
                cfg.LowercaseUrls = true;
            });
            services.AddDbContext<ShopDbContext>(cfg =>
            {
                string connectionString = configuration.GetConnectionString("cString");
                cfg.UseSqlServer(connectionString);
            });


            services.AddIdentity<ShopUser, ShopRole>()
                .AddEntityFrameworkStores<ShopDbContext>();

            services.AddScoped<SignInManager<ShopUser>>();
            services.AddScoped<UserManager<ShopUser>>();
            services.AddScoped<RoleManager<ShopRole>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            app.SeedMemberShip();

            app.UseHttpsRedirection();


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "Admin",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
