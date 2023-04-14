using bookStore.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerModel>> GetAllCustomerAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int customerId);
    }
}
