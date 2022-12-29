using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tutorial_Manager_Final.Areas.Identity.Data;

[assembly: HostingStartup(typeof(Tutorial_Manager_Final.Areas.Identity.IdentityHostingStartup))]
namespace Tutorial_Manager_Final.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<IdContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("IdContextConnection")));

                services.AddDefaultIdentity<IdUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<IdContext>();
            });
        }
    }
}
