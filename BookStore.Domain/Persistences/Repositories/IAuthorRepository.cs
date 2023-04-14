using bookStore.Domain.Entities;

namespace BookStore.Domain.Persistences.Repositories
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {        
        public Task<IEnumerable<Author>?> GetAllAuthorAsync(int pageIndex, int pageSize);
        public Task<IEnumerable<Author>?> GetAllAuthorAsy(int pageIndex, int pageSize);
        public Task<Author?> GetAuthorByIdAsync(int authorId);
    }
}