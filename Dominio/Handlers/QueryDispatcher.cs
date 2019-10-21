using System;
using Dominio.Interfaces.Handlers;

namespace Dominio.Handlers
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceProvider _services;

        public QueryDispatcher(IServiceProvider services)
        {
            _services = services;
        }
        public TResult Dispatch<TFilter, TResult>(TFilter filter)
        where TFilter: new()
        where TResult: new()
        {
            var handler = (IQueryHandler<TFilter, TResult>)_services.GetService(typeof(IQueryHandler<TFilter, TResult>));
            return handler.Retrieve(filter);
        }
    }
}