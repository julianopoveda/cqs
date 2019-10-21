using Microsoft.Extensions.Logging;
using Dominio.Filtros;
using Dominio.Results;
using Dominio.Interfaces.Repositorio;

namespace Dominio.Handlers
{
    public class GetCarsByMarqueAndModelQueryHandler
        : QueryHandler<CarsFilter, CarsResult>       
    {
        private readonly IRepositorio _repositorio;

        public GetCarsByMarqueAndModelQueryHandler( IRepositorio repositorio) 
            : base() { 
                _repositorio = repositorio;
            }

        protected override CarsResult Handle(CarsFilter filter)
        {
            return _repositorio.GetCarByMarqueAndModel(filter);
        }
    }
}