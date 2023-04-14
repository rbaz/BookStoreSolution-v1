using AutoMapper;
using bookStore.Application.Models;
using BookStore.Application.Contracts;
using BookStore.Domain.Persistences.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustomerModel>> GetAllCustomerAsync()
        {
            var customers = await _customerRepository.GetAllCustomerAsync(3, 25);
            return _mapper.Map<IEnumerable<CustomerModel>>(customers);
        }

        public async Task<CustomerModel> GetCustomerByIdAsync(int customerId)
        {
            var customer = await _customerRepository.GetCustomerByIdAsync(customerId);
            return _mapper.Map<CustomerModel>(customer);
        }
    }
}
