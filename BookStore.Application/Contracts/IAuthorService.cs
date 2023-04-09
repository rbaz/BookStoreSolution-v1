using bookStore.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Contracts
{
    public interface IAuthorService
    {
        Task<IEnumerable<AuthorModel>> GetAllAuthorAsync();
        Task<IEnumerable<AuthorModel>> GetAllAuthorAsy();
        Task<AuthorModel> GetAuthorByIdAsync(int id);


        
        //Task<BookModel> AddAsync(AuthorModel author);
        //Task UpdateAsync(AuthorModel author);
        //Task DeleteAsync(int id);
    }
}
