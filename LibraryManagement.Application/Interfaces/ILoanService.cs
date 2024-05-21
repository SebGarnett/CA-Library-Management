using LibraryManagement.Application.LoanItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces;

public interface ILoanService
{
    public Task<LoanDto> CreateLoan(LoanDto loan);
    public Task<Loan> UpdateLoan(LoanDto loan);
    public Task<int> DeleteLoan(Guid id);
    public Task<Loan> GetLoan(Guid id);
}