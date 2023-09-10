using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace CourierServiceDotnet.DBContext
{
    public abstract class RepositoryBase<T> : IRepository<T>
     where T : class
    {
        private readonly DataBaseContext _dbContext;
        public RepositoryBase(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public T Add(T entity)
        {
            var set = _dbContext.Set<T>();
            set.Add(entity);
            return entity;
        }

        public void Remove(T entity)
        {
            var set = _dbContext.Set<T>();
            set.Remove(entity);
        }

        public virtual void Update(T entity)
        {
            var set = _dbContext.Set<T>();
            set.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<T?> Get(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<List<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public IQueryable<T> Query()
        {
            return _dbContext.Set<T>();
        }
    }


}