using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly IAppDbContext _appDbContext;

    public BookRepository(IAppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task AddBook(Book book)
    {
        _ = _appDbContext.Books!.Add(book);
        await _appDbContext.SaveChangesAsync(default);
    }

    public async Task UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteBook(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Book?> GetBookById(Guid id)
    {
        return await _appDbContext.Books!.FindAsync(id);
    }
}