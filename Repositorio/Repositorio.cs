using System;
using System.Collections.Generic;
using Dominio.Filtros;
using Dominio.Interfaces.Repositorio;
using Dominio.Results;
using System.IO;
using System.Linq;

namespace Repositorio
{
    public class CarRepository : IRepositorio
    {
        private readonly IEnumerable<CarsResult> _db;

        public CarRepository()
        {
            if(_db == null)
            {
                StreamReader str = new StreamReader(Path.Combine("db", "db.json"));
                _db = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CarsResult>>(str.ReadToEnd());
            }
        }

        public IEnumerable<CarsResult> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public CarsResult GetCarByMarqueAndModel(CarsFilter filter)
        {
            return _db.FirstOrDefault(f=>f.Marque == filter.Marque && f.Model == filter.Model);
        }
    }
}
