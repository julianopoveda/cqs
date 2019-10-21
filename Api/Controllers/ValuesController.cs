using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Filtros;
using Dominio.Interfaces.Handlers;
using Dominio.Results;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[Controller]")]
    
    public class ValuesController : Controller
    {
        private readonly IQueryDispatcher _queryDispatcher;        
        public ValuesController(IQueryDispatcher queryDispatcher)
        {
            _queryDispatcher = queryDispatcher;
        }

        // GET api/values
        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet()]
        public CarsResult Get(CarsFilter filter)
        {
            return _queryDispatcher.Dispatch<CarsFilter, CarsResult>(filter);
        }
    }
}
