using Delegation.Infrastructure.CQS.Bus;
using Delegation.Infrastructure.CQS.CommandInterfaces;
using Delegation.Infrastructure.CQS.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.CommandHandlers.Login
{
    //public class LoginCommandHandler : IHandleCommand<LoginCommand>
    //{
    //    private readonly LoginUseCase _loginUseCase;
    //    public LoginCommandHandler(LoginUseCase loginUseCase)
    //    {
    //        _loginUseCase = loginUseCase;
    //    }

    //    public async Task<CommandResult> Handle(LoginCommand command)
    //    {
    //        return await _loginUseCase.Login(command);
    //    }
    //}
}
