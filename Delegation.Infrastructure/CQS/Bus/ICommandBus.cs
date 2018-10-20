using Delegation.Infrastructure.CQS.CommandInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Delegation.Infrastructure.CQS.Bus
{
    public interface ICommandsBus
    {
        Task<CommandResult> Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
