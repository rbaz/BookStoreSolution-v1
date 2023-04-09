using bookStore.Application.Models;
using bookStore.Application.Models;
using BookStore.Application.Contracts;
using BookStore.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BookModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllBook()
        {
            var books = await _bookService.GetAllAsync();
            return Ok(books);
        }

        [HttpGet("{bookId}")]
        [ProducesResponseType(typeof(BookModel), StatusCodes.Status200OK)]
        public async Task<BookModel> GetByIdAsync(int bookId)
        {
            return await _bookService.GetByIdAsync(bookId);
        }

    }
}
