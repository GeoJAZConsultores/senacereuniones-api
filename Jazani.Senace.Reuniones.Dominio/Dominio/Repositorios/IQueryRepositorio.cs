namespace Jazani.Senace.Reuniones.Dominio.Dominio.Repositorios
{
    public interface IQueryRepositorio<T, ID>
    {
        Task<IReadOnlyList<T>> FindAllAsync();
    }
}
