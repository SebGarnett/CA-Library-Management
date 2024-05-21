using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces;

public interface IBorrowerRepository
{
    public Task AddBorrower(Borrower borrower);
    public Task UpdateBorrower(Borrower borrower);
    public Task DeleteBorrower(Guid id);
    public Task<Borrower> GetBorrowerById(Guid id);
}