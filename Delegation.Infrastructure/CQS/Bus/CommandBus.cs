using Delegation.Infrastructure.CQS.CommandInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.Bus
{
    public class CommandsBus : ICommandsBus
    {
        private readonly Func<Type, IHandleCommand> _handlersFactory;
        public CommandsBus(Func<Type, IHandleCommand> handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }

        public async Task<CommandResult> Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = (IHandleCommand<TCommand>)_handlersFactory(typeof(TCommand));
            return await handler.Handle(command);
        }
    }
}
