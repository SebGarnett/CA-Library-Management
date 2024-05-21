using LibraryManagement.Application.BookItems.Dtos;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Services;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }
    public async Task<BookDto> CreateBook(BookDto request)
    {
        Book book = new Book
        {
            AuthorId = request.AuthorId,
            Title = request.Name
        };

        await _bookRepository.AddBook(book);

        return new BookDto
        {
            Id = book.Id,
            Name = book.Title,
            AuthorId = book.AuthorId
        };
    }

    public async Task<BookDto> UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Book?> GetBook(Guid id)
    {
        return await _bookRepository.GetBookById(id);
    }
}