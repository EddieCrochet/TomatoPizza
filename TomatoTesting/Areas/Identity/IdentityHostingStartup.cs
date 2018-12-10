using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TomatoPizzaCafe.Models;

[assembly: HostingStartup(typeof(TomatoPizzaCafe.Areas.Identity.IdentityHostingStartup))]
namespace TomatoPizzaCafe.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                var sqlOptions = context.Configuration.Get<SqlServerOptions>();
                var Userinfo = context.Configuration.GetConnectionString("TomatoPizzaCafeContextConnection");
                var UserFormat = String.Format(Userinfo, sqlOptions.UserId, sqlOptions.Password);
                services.AddDbContext<MyIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TomatoPizzaCafeContextConnection")));

                services.AddIdentity<IdentityUser, IdentityRole>(config =>
                {
                    config.SignIn.RequireConfirmedEmail = false;
                })
                    .AddDefaultUI()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<MyIdentityContext>();
            });
        }
    }
}