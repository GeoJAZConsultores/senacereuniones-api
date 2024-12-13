using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Contextos
{
    public static class InfraestructuraServicioRegistro
    {
        public static IServiceCollection addInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AplicacionBDContexto>(options =>
            {
                options.UseOracle(configuration.GetConnectionString("bd_senace"));
            });

            return services;
        }
    }
}
