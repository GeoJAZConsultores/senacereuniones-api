using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Contextos
{
    public static class AplicacionServicioRegistro
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
