namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Datos.Paginado
{
    public class PageRequest<T>
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public T? Filter { get; set; }
    }
}
