using Autofac;
using Delegation.Core.Models;
using Delegation.Infrastructure.Context;
using Delegation.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegation.Infrastructure.IOC.Modules
{
    public class DbContextModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;
        public DbContextModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterType<ApplicationDbContext>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
