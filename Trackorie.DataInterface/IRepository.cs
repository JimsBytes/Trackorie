using System.Linq.Expressions;

namespace Trackorie.DataInterface
{
    public interface IRepository<T> 
    {
        Task<T?> GetById(int id);
        Task<List<T>> List();
        Task<IEnumerable<T>> List(Expression<Func<T, bool>> predicate);
        Task<T> Add(T entity);
        Task Delete(T entity);
        Task Edit(T entity);
    }
}
