using LibraryManagement.Application.AuthorItems.Dtos;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Services;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }
    public async Task<AuthorDto> CreateAuthor(AuthorDto request)
    {
        Author author = new Author
        {
            Name = request.Name
        };

       await _authorRepository.AddAuthor(author);

       return new AuthorDto
       {
           Id = author.Id,
           Name = author.Name
       };
    }
}