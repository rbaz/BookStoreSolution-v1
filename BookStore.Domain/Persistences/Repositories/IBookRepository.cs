using bookStore.Domain.Entities;

namespace BookStore.Domain.Persistences.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        public Task<IEnumerable<Book>> GetAllBookAsync(int pageIndex, int pageSize);
        public Task<Book> GetBookByIdAsync(int id);
    }
}
