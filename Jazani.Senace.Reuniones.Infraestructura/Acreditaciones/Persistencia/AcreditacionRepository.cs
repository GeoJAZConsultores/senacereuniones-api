using Jazani.Senace.Reuniones.Dominio.Acreditaciones.Models;
using Jazani.Senace.Reuniones.Dominio.Acreditaciones.Repository;
using Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Contextos;
using Jazani.Senace.Reuniones.Infraestructura.Infraestructura.Persistencias;

namespace Jazani.Senace.Reuniones.Infraestructura.Acreditaciones.Persistencia
{
    public class AcreditacionRepository : CrudRepositorio<Acreditacion, int>, IAcreditacionRepository
    {
        public AcreditacionRepository(AplicacionBDContexto dbContext) : base(dbContext)
        {
        }
    }
}
