using AutoMapper;
using bookStore.Application.Models;
using BookStore.Application.Contracts;
using BookStore.Domain.Persistences.Repositories;

namespace BookStore.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorModel>> GetAllAuthorAsy()
        {
            var authors = await _authorRepository.GetAllAuthorAsy(3, 25);
            return _mapper.Map<IEnumerable<AuthorModel>>(authors);
        }

        public async Task<IEnumerable<AuthorModel>> GetAllAuthorAsync()
        {
            var authors = await _authorRepository.GetAllAuthorAsync(3, 25);
            return _mapper.Map<IEnumerable<AuthorModel>>(authors);
        }

        public async Task<AuthorModel> GetAuthorByIdAsync(int id)
        {
            var author = await _authorRepository.GetAuthorByIdAsync(id);
            return _mapper.Map<AuthorModel>(author);
        }

        //public async Task<IEnumerable<AuthorModel>> GetAll(int pageNumber, int pageSize)
        //{
        //    var authors = await _authorRepository.GetAll(pageNumber, pageSize);
        //    return _mapper.Map<IEnumerable<AuthorModel>>(authors);
        //}
    }
}
