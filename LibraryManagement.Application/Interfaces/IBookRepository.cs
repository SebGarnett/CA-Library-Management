using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces;

public interface IBookRepository
{
    public Task AddBook(Book book);
    public Task UpdateBook(Book book);
    public Task DeleteBook(Guid id);
    public Task<Book> GetBookById(Guid id);
}