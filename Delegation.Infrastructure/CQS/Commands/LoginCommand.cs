using Delegation.Infrastructure.CQS.CommandInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.Commands
{
    public class LoginCommand : ICommand
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
