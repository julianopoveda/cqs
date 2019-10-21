using System.Collections.Generic;
using Dominio.Filtros;
using Dominio.Results;

namespace Dominio.Interfaces.Repositorio
{   
    public interface IRepositorio
    {
        IEnumerable<CarsResult> GetAllCars();
        CarsResult GetCarByMarqueAndModel(CarsFilter filter);
    }
}