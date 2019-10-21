using System;
using Microsoft.Extensions.DependencyInjection;
using Dominio.Handlers;
using Dominio.Interfaces.Handlers;
using Dominio.Filtros;
using Dominio.Results;
using Dominio.Interfaces.Repositorio;
using Repositorio;

namespace IoC
{
    public class IoCQueryHandler
    {
        public static IServiceCollection ConfiguraRepositorioIoC(IServiceCollection services)
        {
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();
            services.AddScoped<IQueryHandler<CarsFilter, CarsResult>, GetCarsByMarqueAndModelQueryHandler>();

            services.AddScoped<IRepositorio, CarRepository>();
            return services;
        }
    }
}
