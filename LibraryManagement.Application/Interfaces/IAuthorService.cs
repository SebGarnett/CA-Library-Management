using LibraryManagement.Application.AuthorItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces;

public interface IAuthorService
{
    public Task<AuthorDto> CreateAuthor(AuthorDto author);
}