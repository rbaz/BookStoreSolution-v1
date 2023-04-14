using bookStore.Application.Models;

namespace BookStore.Application.Contracts
{
    public interface IAuthorService
    {        
        Task<IEnumerable<AuthorModel>> GetAllAuthorAsync();
        Task<IEnumerable<AuthorModel>> GetAllAuthorAsy();
        Task<AuthorModel> GetAuthorByIdAsync(int authorId);
                
        //Task<BookModel> AddAsync(AuthorModel author);
        //Task UpdateAsync(AuthorModel author);
        //Task DeleteAsync(int id);
    }
}
