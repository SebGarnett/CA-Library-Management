using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure.Repositories;

public class BorrowerRepository : IBorrowerRepository
{
    private readonly IAppDbContext _appDbContext;

    public BorrowerRepository(IAppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
       
    public async Task AddBorrower(Borrower borrower)
    {
        _appDbContext.Borrowers!.Add(borrower);
        await _appDbContext.SaveChangesAsync(default);
    }

    public async Task UpdateBorrower(Borrower borrower)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteBorrower(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Borrower?> GetBorrowerById(Guid id)
    {
       return await _appDbContext.Borrowers!.FindAsync(id);
    }
}