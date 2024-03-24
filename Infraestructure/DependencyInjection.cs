using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces.Repositories;
using Infraestructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AgregarInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<IDomicilioRepository, DomicilioRepository>();
            return services;
        }
    }
}
