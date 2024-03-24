using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AgregarCore(this IServiceCollection services)
        {
            services.AddScoped<IPersonaService, PersonaService>();
            services.AddScoped<IDomicilioService, DomicilioService>();
            return services;
        }
    }
}
