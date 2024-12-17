namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface IUpdateService<TDto, ID>
    {
        Task<TDto> UpdateAsync(ID id);
    }
}
