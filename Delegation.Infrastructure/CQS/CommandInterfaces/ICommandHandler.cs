using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.CommandInterfaces
{
    public interface ICommandHandler<TParameter> where TParameter : ICommand
    {
        Task<CommandResult> HandleAsync(TParameter command);
    }
}
