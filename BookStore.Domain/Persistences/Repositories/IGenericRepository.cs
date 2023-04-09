using System.Linq.Expressions;

namespace BookStore.Domain.Persistences.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync(int pageIndex, int pageSize);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
        public Task<T> AddAsync(T entity);
        public Task<IEnumerable<T>> AddRange(IEnumerable<T> entities);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task<IEnumerable<T>> RemoveRange(IEnumerable<T> entities);

    }
}
