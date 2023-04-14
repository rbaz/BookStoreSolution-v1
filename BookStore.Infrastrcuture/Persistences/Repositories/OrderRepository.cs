using bookStore.Domain.Entities;
using BookStore.Domain.Persistences.Repositories;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastrcuture.Persistences.Repositories
{
    public class OrderRepository : GenericRepository<CustOrder>, IOrderRepository
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<CustOrder> _dbSet;
        public OrderRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<CustOrder>();
        }
        public async Task<IEnumerable<CustOrder>> GetAllOrderAsync(int pageIndex, int pageSize)
        {
            var orders = await _dbSet
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return orders;
        }       

        public async Task<CustOrder> GetOrderByIdAsync(int orderId)
        {
            var order = await _dbSet
                .Include(o => o.Customer)
                .FirstOrDefaultAsync(o => o.OrderId == orderId);

            return order;
        }
    }
}
