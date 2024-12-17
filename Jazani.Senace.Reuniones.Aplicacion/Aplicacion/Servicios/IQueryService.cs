namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface IQueryService<TDto, ID>
    {
        Task<IReadOnlyList<TDto>> FindAllAsync();
        Task<IReadOnlyList<TDto>> FindGeneralAsync(ID id);
        Task<TDto> FindByIdAsync(ID id);
    }
}
