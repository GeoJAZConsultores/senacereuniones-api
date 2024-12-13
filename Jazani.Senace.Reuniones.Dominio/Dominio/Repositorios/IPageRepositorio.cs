using Jazani.Senace.Reuniones.Dominio.Dominio.Modelos;
using System.Linq.Expressions;

namespace Jazani.Senace.Reuniones.Dominio.Dominio.Repositorios
{
    public interface IPageRepositorio<T>
    {
        Task<PagedResult<T>> FindAllPaginatedAsync(Paging paginado,
                                      Expression<Func<T, bool>> predicate);
        Task<PagedResult<T>> FindAllPaginatedAsync(Paging paging,
                                       Expression<Func<T, bool>>? predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                       List<Expression<Func<T, object>>>? includes = null,
                                       bool disableTracking = true,
                                       Expression<Func<T, T>>? selector = null, bool defaultIfEmpty = false, List<string> includeString = null);
    }
}
