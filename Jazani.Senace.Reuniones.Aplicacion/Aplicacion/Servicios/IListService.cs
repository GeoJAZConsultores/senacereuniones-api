namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface IListService<TDto>
    {
        Task<IReadOnlyList<TDto>> SimpleListAsync();
    }
}
