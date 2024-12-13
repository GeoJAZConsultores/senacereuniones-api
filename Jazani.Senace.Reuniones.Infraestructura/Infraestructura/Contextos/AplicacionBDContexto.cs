using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Contextos
{
    public class AplicacionBDContexto : DbContext
    {
        public AplicacionBDContexto(DbContextOptions<AplicacionBDContexto> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
