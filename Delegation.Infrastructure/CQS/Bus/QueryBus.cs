using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation.Infrastructure.CQS.Bus.Result;
using Delegation.Infrastructure.CQS.QueryInterfaces;

namespace Delegation.Infrastructure.CQS.Bus
{
    public class QueryBus : IQueryBus
    {
        private readonly Func<Type, IHandleQuery> _handlersFactory;
        public QueryBus(Func<Type, IHandleQuery> handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }
        public async Task<QueryResult> Send<TQuery>(TQuery query) where TQuery : IQuery
        {
            var handler = (IHandleQuery<TQuery>)_handlersFactory(typeof(TQuery));
            return await handler.Handle(query);
        }
    }
}
