using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.LoanItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure.Repositories;

public class LoanRepository : ILoanRepository
{
    private readonly IAppDbContext _appDbContext;

    public LoanRepository(IAppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task AddLoan(Loan loan)
    {
        _appDbContext.Loans!.Add(loan);
        await _appDbContext.SaveChangesAsync(default);
        
    }

    public async Task UpdateLoan(Loan loan)
    {
        throw new NotImplementedException();
    }
}