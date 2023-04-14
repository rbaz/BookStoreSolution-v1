using BookStore.Application.Contracts;
using bookStore.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<CustomerModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCustomerAsync()
        {
            var customers = await _customerService.GetAllCustomerAsync();

            return Ok(customers);
        }

        [HttpGet("{customerId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CustomerModel), StatusCodes.Status200OK)]
        public async Task<CustomerModel> GetCustomerByIdAsync(int customerId)
        {
            var customer = await _customerService.GetCustomerByIdAsync(customerId);

            return customer;
        }
    }
}
