using Delegation.Infrastructure.CQS.CommandInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.Bus
{
    public interface IHandleCommand
    {
    }
    public interface IHandleCommand<TCommand> : IHandleCommand
    where TCommand : ICommand
    {
        Task<CommandResult> Handle(TCommand command);
    }
}
