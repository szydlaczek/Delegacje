using Delegation.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation.Infrastructure.Identity
{
    public static class IdentityConfiguration
    {
        public static void Register(IServiceCollection services)
        {

            services
                .AddSingleton<IRoleStore<Role>, RoleStore>()
                .AddSingleton<RoleStore>()
                .AddSingleton<IUserStore<User>, UserStore>();
            services.AddIdentity<User, Role>(ConfigureIdentityOptions)
                .AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options => options.ExpireTimeSpan = TimeSpan.FromDays(30));
        }
        private static void ConfigureIdentityOptions(IdentityOptions options)
        {
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
        }
    }
}
