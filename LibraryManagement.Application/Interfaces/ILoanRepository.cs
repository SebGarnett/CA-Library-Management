using LibraryManagement.Application.LoanItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces;

public interface ILoanRepository
{
    public Task AddLoan(Loan loan);
    public Task UpdateLoan(Loan loan);
    
}