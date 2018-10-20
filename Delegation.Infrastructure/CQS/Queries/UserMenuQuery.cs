using Delegation.Infrastructure.CQS.QueryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.Queries
{
    public class UserMenuQuery : IQuery
    {
        public string UserId { get; set; }
    }
}
