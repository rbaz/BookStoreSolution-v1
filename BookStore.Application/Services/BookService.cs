using AutoMapper;
using bookStore.Application.Models;
using bookStore.Domain.Entities;
using BookStore.Domain.Persistences.Repositories;

namespace BookStore.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<BookModel>> GetAllAsync()
        {
            var books = await _bookRepository.GetAllBookAsync(pageIndex: 3, pageSize: 25);
            return _mapper.Map<IEnumerable<BookModel>>(books);
        }

        public async Task<BookModel> GetByIdAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            return _mapper.Map<BookModel>(book);
        }

        //public async Task<BookModel> AddAsync(BookModel bookModel)
        //{
        //    var book = _mapper.Map<Book>(bookModel);
        //    var addedBook = await _bookRepository.AddAsync(book);
        //    return _mapper.Map<BookModel>(addedBook);
        //}

        //public async Task UpdateAsync(BookModel bookModel)
        //{
        //    var book = _mapper.Map<Book>(bookModel);
        //    await _bookRepository.UpdateAsync(book);
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var book = await _bookRepository.GetByIdAsync(id);
        //    await _bookRepository.DeleteAsync(book);
        //}        

    }
}
