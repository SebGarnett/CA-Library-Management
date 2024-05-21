using LibraryManagement.Application.BorrowerItems.Dtos;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Services;

public class BorrowerService : IBorrowerService
{
    private readonly IBorrowerRepository _borrowerRepository;

    public BorrowerService(IBorrowerRepository borrowerRepository)
    {
        _borrowerRepository = borrowerRepository;
    }

    public async Task<BorrowerDto> CreateBorrower(BorrowerDto request)
    {
        Borrower borrower = new Borrower
        {
            Name = request.Name
        };

        await _borrowerRepository.AddBorrower(borrower);

        return new BorrowerDto
        {
            Id = borrower.Id,
            Name = borrower.Name

        };
    }

    public async Task<BorrowerDto> UpdateBorrower(BorrowerDto request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteBorrower(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Borrower> GetBorrower(Guid id)
    {
        return await _borrowerRepository.GetBorrowerById(id);
    }
}