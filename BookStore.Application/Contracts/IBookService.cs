using bookStore.Application.Models;
using bookStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookModel>> GetAllAsync();
        Task<BookModel> GetByIdAsync(int id);
        
        //Task<BookModel> AddAsync(BookModel book);
        //Task UpdateAsync(BookModel book);
        //Task DeleteAsync(int id);
    }
}
