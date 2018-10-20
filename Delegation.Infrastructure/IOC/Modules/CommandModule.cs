using Autofac;
using Delegation.Infrastructure.CQS.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.IOC
{
    public class CommandModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            base.Load(builder);
            builder.RegisterAssemblyTypes(ThisAssembly)
            .Where(x => x.IsAssignableTo<IHandleCommand>())
            .AsImplementedInterfaces();
            builder.Register<Func<Type, IHandleCommand>>(c =>
            {
                var ctx = c.Resolve<IComponentContext>();

                return t =>
                {
                    var handlerType = typeof(IHandleCommand<>).MakeGenericType(t);
                    return (IHandleCommand)ctx.Resolve(handlerType);
                };
            });

            builder.RegisterType<CommandsBus>()
                .AsImplementedInterfaces();
        }
    }
}
