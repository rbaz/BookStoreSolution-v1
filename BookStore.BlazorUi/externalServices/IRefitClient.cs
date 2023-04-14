using BookStore.BlazorUi.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace BookStore.BlazorUi.externalServices
{
    public interface IRefitClient
    {
        [Get("/order")]
        //Task<IActionResult> GetAllOrderAsync();
        Task<IEnumerable<CustOrder>> GetAllOrderAsync();
    }
}
