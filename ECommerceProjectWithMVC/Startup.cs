using ECommerceProjectWithMVC.AppCode.Providers;
using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities.Membership;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

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
            services.AddMediatR(typeof(Startup).Assembly);


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
                .AddEntityFrameworkStores<ShopDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<SignInManager<ShopUser>>();
            services.AddScoped<UserManager<ShopUser>>();
            services.AddScoped<RoleManager<ShopRole>>();

            services.AddScoped<IClaimsTransformation,AppClaimProvider>();

            //services.AddSingleton<IActionContextAccessor,ActionContextAccessor>();//CQRS ModelState
            services.AddAuthentication();
            services.AddAuthorization(cfg =>
            {
                foreach (var claimName in AppClaimProvider.policies)
                {
                    

                    cfg.AddPolicy(claimName, p =>
                    {
                        p.RequireAssertion(a =>
                        {

                            return a.User.HasClaim(claimName, "1")
                            || a.User.IsInRole("SuperAdmin");

                        });
                        //p.RequireClaim(claimName, "1");
                    });
                }

                
            });


            services.ConfigureApplicationCookie(cfg =>
            {

                cfg.Cookie.Name = "shop";
                cfg.Cookie.HttpOnly = true;
                cfg.ExpireTimeSpan =new TimeSpan(0,5,0);
                cfg.LoginPath = "/signin.html";
                cfg.AccessDeniedPath = "/accessdenied.html";

               

            });


            services.Configure<IdentityOptions>(cfg =>
            {
                //cfg.User.AllowedUserNameCharacters = "qwertadsghjkl";

                cfg.User.RequireUniqueEmail = true;
                cfg.Password.RequireDigit = true;
                cfg.Password.RequiredLength = 6;
                cfg.Password.RequiredUniqueChars = 1;
                cfg.Password.RequireUppercase = true;
                cfg.Password.RequireNonAlphanumeric = false;
                cfg.Lockout.MaxFailedAccessAttempts = 5;

                cfg.Lockout.DefaultLockoutTimeSpan = new TimeSpan(0,5,0);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }


            app.UseHttpsRedirection();


            

            app.UseRouting();


            app.SeedMemberShip();

            app.UseStaticFiles();



            app.UseAuthentication();
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
