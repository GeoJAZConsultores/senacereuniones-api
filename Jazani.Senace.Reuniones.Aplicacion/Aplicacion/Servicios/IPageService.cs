using Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Datos.Paginado;

namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface IPageService<TDto, TDtoFilter>
    {
        Task<PageResponse<TDto>> FindAllPaginatedAsync(PageRequest<TDtoFilter> request);
    }
}
