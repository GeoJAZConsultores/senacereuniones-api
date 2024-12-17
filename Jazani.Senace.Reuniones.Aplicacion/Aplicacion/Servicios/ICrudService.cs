namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Servicios
{
    public interface ICrudService<TDto, TDtoSave, ID> : IQueryService<TDto, ID>, ISaveService<TDto, TDtoSave, ID>,
     IDisableService<TDto, ID>, IUpdateService<TDto, ID>
    {
    }
}
