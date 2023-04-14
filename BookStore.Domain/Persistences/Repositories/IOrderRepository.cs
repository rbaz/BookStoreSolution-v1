using bookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Persistences.Repositories
{
    public interface IOrderRepository : IGenericRepository<CustOrder>
    {
        public Task<IEnumerable<CustOrder>> GetAllOrderAsync(int pageIndex, int pageSize);
        public Task<CustOrder> GetOrderByIdAsync(int orderId);
    }
}
