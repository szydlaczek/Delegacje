﻿using Delegation.Infrastructure.CQS.Bus.Result;
using Delegation.Infrastructure.CQS.QueryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation.Infrastructure.CQS.Bus
{
    public interface IQueryBus
    {
        Task<QueryResult> Send<TQuery>(TQuery query) where TQuery : IQuery;
    }
}
