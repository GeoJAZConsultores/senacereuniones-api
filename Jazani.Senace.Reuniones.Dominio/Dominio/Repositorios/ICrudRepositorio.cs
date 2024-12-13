using System.Linq.Expressions;

namespace Jazani.Senace.Reuniones.Dominio.Dominio.Repositorios
{
    public interface ICrudRepositorio<T, ID> : IPageRepositorio<T>
    {
        Task<IReadOnlyList<T>> FindAllAsync();
        Task<T?> FindByIdAsync(ID id);
        Task<T> SaveAsync(T entity);
        Task RemoveByIdAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T?> FindByIdAsync(Expression<Func<T, bool>> predicate,
                                       List<Expression<Func<T, object>>>? includes = null,
                                       bool disableTracking = true,
                                       bool DefaultIfEmpty = false,
                                       List<string> includeString = null);
        Task<T?> FindFirstOrDefaultAsync(Expression<Func<T, bool>> predicate,
                                       List<Expression<Func<T, object>>>? includes = null,
                                       bool disableTracking = true);
        Task<IReadOnlyList<T>> FindAllAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> FindAllAsync(Expression<Func<T, bool>>? predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                       List<Expression<Func<T, object>>>? includes = null,
                                       bool disableTracking = true,
                                       Expression<Func<T, T>>? selector = null,
                                       bool DefaultIfEmpty = false,
                                       List<string> includeString = null);
    }
}
