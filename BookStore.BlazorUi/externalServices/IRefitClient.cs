using BookStore.BlazorUi.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BookStore.BlazorUi.externalServices
{
    public interface IRefitClient
    {
        [Get("/order")]
        //Task<IActionResult> GetAllOrderAsync();
        Task<ICollection<CustOrderModel>> GetAllOrderAsync();

        //[Get("/order")]        
        //Task<IEnumerable<OrderLine>> GetOrderLineAsync(int orderId);
    }
}
