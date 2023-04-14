using bookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Persistences.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        public Task<IEnumerable<Customer>> GetAllCustomerAsync(int pageIndex, int pageSize);
        public Task<Customer> GetCustomerByIdAsync(int customerId);
    }
}
