using bookStore.Application.Models;
using bookStore.Domain.Entities;
using BookStore.Application.Contracts;
using BookStore.Application.Filter;
using BookStore.Application.Services;
using BookStore.Application.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }        

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<AuthorModel>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllAuthorAsync()
        {
            //var authors = await _authorService.GetAllAuthorAsync();
            var authors = await _authorService.GetAllAuthorAsy();

            return Ok(authors);
        }

        [HttpGet("{authorId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(AuthorModel), StatusCodes.Status200OK)]
        public async Task<AuthorModel> GetAuthorByIdAsync(int authorId)
        {
            var author = await _authorService.GetAuthorByIdAsync(authorId);

            return author;
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(AuthorModel), StatusCodes.Status200OK)]
        //public async Task<ActionResult<IEnumerable<AuthorModel>>> GetAllAuthorActionResult()
        //{
        //    var authors = await _authorService.GetAllAuthorAsync();
            
        //    return Ok(authors);
        //}

    }
}
