using System;
using Dominio.Interfaces.Handlers;
using Microsoft.Extensions.Logging;

namespace Dominio.Handlers
{
    public abstract class QueryHandler<TFiltro, TResult> : IQueryHandler<TFiltro, TResult>
    where TFiltro: new()
    where TResult: new()
    {
        protected readonly ILogger _log;

        public QueryHandler()
        {    
            _log = null;
        }

        public TResult Retrieve(TFiltro filter)
        {
            TResult queryResult = new TResult();
            try{
                queryResult = Handle(filter);
                return queryResult;
            }
            catch(Exception ex)
            {
                _log.LogError("Erro ao executar a resquisição {0}", ex.Message);
                throw;
            }            
        }

        protected abstract TResult Handle(TFiltro filter);        
    }
}