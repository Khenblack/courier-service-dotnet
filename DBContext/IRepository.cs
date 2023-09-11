using System.Linq.Expressions;

namespace CourierServiceDotnet.DBContext
{
    public interface IRepository<T> where T : class
    {
        Task<T?> Get(Expression<Func<T, bool>> predicate);
        Task<bool> SaveChanges();
        Task<T> Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        IQueryable<T> Query();
        Task<List<T>> GetAll();
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate);
    }


}