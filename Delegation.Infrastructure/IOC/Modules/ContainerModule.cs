using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Delegation.Infrastructure.Context;

namespace Delegation.Infrastructure.IOC.Modules
{
    public class ContainerModule : Autofac.Module
    {
        private readonly IConfiguration _configuration;
        public ContainerModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            
            builder.RegisterModule(new DbContextModule(_configuration));
            builder.RegisterModule<CommandModule>();
            builder.RegisterModule<QueryModule>();
        }
    }
}
