using bookStore.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<CustOrderModel>> GetAllOrderAsync();
        Task<CustOrderModel> GetOrderByIdAsync(int orderId);
        //Task<IEnumerable<OrderLineModel>> GetOrderLineAsync(int orderId);
    }
}
