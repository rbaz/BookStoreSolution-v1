using bookStore.Domain.Entities;
using BookStore.Domain.Persistences.Repositories;
using BookStore.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastrcuture.Persistences.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<Customer> _dbSet;
        public CustomerRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Customer>();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomerAsync(int pageIndex, int pageSize)
        {
            var customers = await _dbSet
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return customers;
        }

        public async Task<Customer> GetCustomerByIdAsync(int customerId)
        {
            var customer = await _dbSet
                .Include(o => o.CustomerAddresses)
                .Include(o => o.CustOrders)
                .FirstOrDefaultAsync(o => o.CustomerId == customerId);

            return customer;
        }
    }
}
