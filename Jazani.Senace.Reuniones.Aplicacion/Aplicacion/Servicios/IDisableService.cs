namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface IDisableService<TDto, ID>
    {
        Task<TDto> DisabledAsync(ID id);
    }
}
