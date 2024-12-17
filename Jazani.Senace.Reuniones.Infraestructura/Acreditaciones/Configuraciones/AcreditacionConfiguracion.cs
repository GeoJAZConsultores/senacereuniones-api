using Jazani.Senace.Reuniones.Dominio.Acreditaciones.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jazani.Senace.Reuniones.Infraestructura.Acreditaciones.Configuraciones
{
    internal class AcreditacionConfiguracion : IEntityTypeConfiguration<Acreditacion>
    {
        public void Configure(EntityTypeBuilder<Acreditacion> builder)
        {
            builder.ToTable("" , "");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID_ACREDITACION");


        }
    }
}
