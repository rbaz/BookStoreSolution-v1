using bookStore.Application.Models;
using BookStore.Application.Contracts;
using BookStore.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<CustOrderModel>), StatusCodes.Status200OK)]
        //public async Task<IActionResult> GetAllOrderAsync()
        public async Task<IActionResult> GetAllOrderAsync()
        {            
            var orders = await _orderService.GetAllOrderAsync();

            return Ok(orders);
        }

        [HttpGet("{orderId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustOrderModel), StatusCodes.Status200OK)]
        public async Task<CustOrderModel> GetOrderByIdAsync(int orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);

            return order;
        }

        //[HttpGet("{orderId}")]
        //[Produces("application/json")]
        //[ProducesResponseType(typeof(IEnumerable<OrderLineModel>), StatusCodes.Status200OK)]        
        //public async Task<IEnumerable<OrderLineModel>> GetOrderLineAsync(int orderId)
        //{
        //    var orderLines = await _orderService.GetOrderLineAsync(orderId);

        //    return orderLines;
        //}
    }
}
