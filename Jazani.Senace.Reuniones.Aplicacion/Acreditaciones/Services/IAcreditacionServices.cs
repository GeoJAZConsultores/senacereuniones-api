using Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Models.Acreditaciones;
using Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios;

namespace Jazani.Senace.Reuniones.Aplicacion.Acreditaciones.Services
{
    public interface IAcreditacionServices : ICrudService<AcreditacionDto, AcreditacionSaveDto, int>, IPageService<AcreditacionDto, AcreditacionFilterDto>
    {
    }
}
