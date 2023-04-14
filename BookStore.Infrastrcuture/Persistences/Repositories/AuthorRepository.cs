using bookStore.Domain.Entities;
using BookStore.Domain.Persistences.Repositories;
using BookStore.Infrastrcuture.Persistences.Repositories;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure.Persistences.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<Author> _dbSet;

        public AuthorRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Author>();
        }
                
        public async Task<IEnumerable<Author>> GetAllAuthorAsync(int pageIndex, int pageSize)
        {

            var authors = await _dbSet
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            foreach (var author in authors)
            {
                await _dbContext.Entry(author)
                    .Collection(a => a.Books)
                    .Query()
                    .Include(b => b.Language)
                    .Include(b => b.OrderLines)
                    .Include(b => b.Publisher)                    
                    .LoadAsync();
            }

            return authors;

        }

        public async Task<IEnumerable<Author>> GetAllAuthorAsy(int pageIndex, int pageSize)
        {
            //var authorModels = await _dbContext.Authors
            //                    .OrderBy(a => a.AuthorName)
            //                    .Skip((pageIndex - 1) * pageSize)
            //                    .Take(pageSize)
            //                    .Select(a => new Author
            //                    {
            //                        AuthorId = a.AuthorId,
            //                        AuthorName = a.AuthorName
            //                    })
            //                    .ToListAsync();

            //return authorModels;
            var authorModels = await _dbContext.Authors
                    .Include(a => a.Books)
                    .OrderBy(a => a.AuthorName)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

            return authorModels;

        }

        public async Task<Author?> GetAuthorByIdAsync(int authorId)
        {
            var author = await _dbContext.Authors
                .Include(a => a.Books)
                .FirstOrDefaultAsync(a => a.AuthorId == authorId);

            return author;
        }

        public async Task<Author> GetByIdAsyncSave(int id)
        {
            var author = await _dbContext.Authors
                .Include(a => a.Books)
                .ThenInclude(b => b.Language)
                .Include(a => a.Books)
                .ThenInclude(b => b.Publisher)
                .Include(a => a.Books)
                .ThenInclude(b => b.OrderLines)
                .ThenInclude(ol => ol.Order)
                .ThenInclude(b => b.OrderLines)
                .ThenInclude(ol => ol.Book)
                .FirstOrDefaultAsync(a => a.AuthorId == id);

            return author;
        }
    }

    //public async Task<IReadOnlyList<Author>> GetAllAsync()
    //{
    //    var authors = await _dbSet
    //            .Include(b => b.Books)
    //            .ToListAsync();

    //    return authors;
    //}

    //public async Task<Author?> GetByIdAsync(int id)
    //{
    //    var author = await _dbSet.Include(a => a.Books)
    //                    .ThenInclude(b => b.Language)
    //                    .Include(a => a.Books)
    //                    .ThenInclude(b => b.Publisher)
    //                    .Include(a => a.Books)
    //                    .ThenInclude(b => b.OrderLines)
    //                        .ThenInclude(ol => ol.Order)
    //                            .ThenInclude(c => c.Customer)
    //                    .Include(a => a.Books)
    //                    .ThenInclude(b => b.OrderLines)
    //                        .ThenInclude(ol => ol.Order)
    //                            .ThenInclude(sh => sh.ShippingMethod)
    //                    .Include(a => a.Books)
    //                    .ThenInclude(b => b.OrderLines)
    //                        .ThenInclude(ol => ol.Order)
    //                            .ThenInclude(oh => oh.OrderHistories)
    //                                .ThenInclude(os=>os.Status)
    //                    .Include(a => a.Books)
    //                    .ThenInclude(b => b.OrderLines)
    //                        .ThenInclude(ol => ol.Order)
    //                            .ThenInclude(ad => ad.DestAddress)
    //                                .ThenInclude(co=>co.Country)
    //                    .FirstOrDefaultAsync(a => a.AuthorId == id);


    //    if (author == null)
    //    {
    //        return null; // or return a not-found response
    //    }

    //    return author;
    //}


    //public async Task<Author> GetByIdAsyncSave(int id)
    //{
    //    var author = await _dbSet.Include(a => a.Books)
    //                  .ThenInclude(b => b.Language)
    //                  .Include(a => a.Books)
    //                  .ThenInclude(b => b.Publisher)
    //                  .Include(a => a.Books)
    //                  .ThenInclude(b => b.OrderLines)
    //                      .ThenInclude(ol => ol.Order)
    //                  .ThenInclude(b => b.OrderLines)
    //                      .ThenInclude(ol => ol.Book)
    //                  .FirstOrDefaultAsync(a => a.AuthorId == id);



    //    if (author == null)
    //    {
    //        return null; // or return a not-found response
    //    }

    //    return author;
    //}

}

//var author = await _dbSet.Include(a => a.Books)
//                          .ThenInclude(b => b.Language)
//                          .Include(a => a.Books)
//                          .ThenInclude(b => b.Publisher)
//                          .Include(a => a.Books)
//                          .ThenInclude(b => b.OrderLines)
//                              .ThenInclude(ol => ol.Order)
//                                  .ThenInclude(o => o.Customer)
//                                  .ThenInclude(c => c.CustomerAddresses)
//                          .Include(a => a.Books)
//                          .ThenInclude(b => b.OrderLines)
//                              .ThenInclude(ol => ol.Book)
//                          .FirstOrDefaultAsync(a => a.AuthorId == id);


//var author = await _dbSet
//                            .Include(a => a.Books)
//                                .ThenInclude(b => b.Language)
//                            .Include(a => a.Books)
//                                .ThenInclude(b => b.Publisher)
//                            .Include(a => a.Books)
//                                .ThenInclude(b => b.OrderLines)
//                                    .ThenInclude(ol => ol.Order)
//                                .ThenInclude(o => o.Customer)
//                            .Include(a => a.Books)
//                                .ThenInclude(b => b.OrderLines)
//                                    .ThenInclude(ol => ol.Book)
//                                        .ThenInclude(b => b.Language)
//                            .FirstOrDefaultAsync(a => a.AuthorId == id);
