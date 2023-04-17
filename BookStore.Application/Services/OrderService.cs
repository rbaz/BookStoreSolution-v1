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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CustOrderModel>> GetAllOrderAsync()
        {
            var orders = await _orderRepository.GetAllOrderAsync(1, 25);
            return _mapper.Map<IEnumerable<CustOrderModel>>(orders);
        }

        

        public async Task<CustOrderModel> GetOrderByIdAsync(int orderId)
        {
            var order = await _orderRepository.GetOrderByIdAsync(orderId);
            return _mapper.Map<CustOrderModel>(order);
        }

        //public async Task<IEnumerable<OrderLineModel>> GetOrderLineAsync(int orderId)
        //{
        //    var orderLines = await _orderRepository.GetOrderLineAsync(orderId);
        //    return _mapper.Map<IEnumerable<OrderLineModel>>(orderLines);
        //}        
    }
}
