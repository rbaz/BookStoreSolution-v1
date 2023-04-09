using bookStore.Domain.Entities;
using BookStore.Domain.Persistences.Repositories;
using BookStore.Infrastrcuture.Persistences.Repositories;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace BookStore.Infrastructure.Persistences.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<Book> _dbSet;

        public BookRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Book>();
        }
        public async Task<IReadOnlyList<Book>> GetAllBookAsync()
        {
            return await _dbSet
                    .Include(b => b.Authors)
                    .Include(b => b.Language)
                    .Include(b => b.Publisher)
                    .ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var book = await _dbSet.Include(b => b.Language)
                                    .Include(b => b.Publisher)
                                    .Include(b => b.Authors)
                                    .Include(b => b.OrderLines)
                                        .ThenInclude(ol => ol.Order)
                                    .FirstOrDefaultAsync(b => b.BookId == id);

            return book;
        }



        public async Task<IEnumerable<Book>> Find(Expression<Func<Book, bool>> expression)
        {
            return await _dbSet
                .Include(b => b.Language)
                .Include(b => b.Publisher)
                .Include(b => b.Authors)
                .Include(b => b.OrderLines)
                    .ThenInclude(ol => ol.Order)
                .Where(expression)
                .ToListAsync();
        }

        public async Task<Book> AddAsync(Book entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Book>> AddRange(IEnumerable<Book> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
            return entities;
        }

        public async Task UpdateAsync(Book entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Book entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> RemoveRange(IEnumerable<Book> entities)
        {
            _dbSet.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
            return entities;
        }

        public async Task<IEnumerable<Book>> GetAllBookAsync(int pageIndex, int pageSize)
        {
            return await _dbSet.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        }        
    }
}
