using ECommerceProjectWithMVC.AppCode.Providers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ECommerceProjectWithMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var types = Assembly.GetExecutingAssembly().GetTypes();

            AppClaimProvider.policies = types
                    .Where(t => typeof(ControllerBase).IsAssignableFrom(t) && t.IsDefined(typeof(AuthorizeAttribute), true))
                    .SelectMany(t => t.GetCustomAttributes<AuthorizeAttribute>())
                    .Union(types
                    .Where(t => typeof(ControllerBase).IsAssignableFrom(t))
                    .SelectMany(type => type.GetMethods())
                    .Where(method => method.IsPublic
                        && !method.IsDefined(typeof(NonActionAttribute))
                        && method.IsDefined(typeof(AuthorizeAttribute)))
                    .SelectMany(t => t.GetCustomAttributes<AuthorizeAttribute>()))
                    .Where(a => !string.IsNullOrWhiteSpace(a.Policy))
                    .SelectMany(a => a.Policy.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    .Distinct()
                    .ToArray();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
