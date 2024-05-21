using System.ComponentModel.DataAnnotations;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.LoanItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Services;

public class LoanService : ILoanService
{
    private readonly IBookService _bookService;
    private readonly IBorrowerService _borrowerService;
    private readonly ILoanRepository _loanRepository;

    public LoanService(IBookService bookService, IBorrowerService borrowerService, ILoanRepository loanRepository)
    {
        _bookService = bookService;
        _borrowerService = borrowerService;
        _loanRepository = loanRepository;
    }
    public async Task<LoanDto> CreateLoan(LoanDto command)
    {
        
        var book = await _bookService.GetBook(command.BookId);
        if (book is null)
            throw new ValidationException($"No such book with id : {command.BookId}");
        
        var borrower = await _borrowerService.GetBorrower(command.BorrowerId);
        if (borrower is null) 
            throw new ValidationException($"No such borrower with id : {command.BorrowerId}");


        ///todo check book availability
         

        Loan loan = new Loan
        {
            Book = book,
            Borrower = borrower,
            LoanDate = command.LoanDate,
            ReturnDate = command.EndDate
        };
        await _loanRepository.AddLoan(loan);

        return new LoanDto
        {
            Id = loan.Id,
            BookId = loan.Book.Id,
            BorrowerId = loan.Borrower.Id,
            LoanDate = loan.LoanDate,
            EndDate = loan.ReturnDate
        };


    }

    public async Task<Loan> UpdateLoan(LoanDto command)
    {
        throw new NotImplementedException();
    }

    public async Task<int> DeleteLoan(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Loan> GetLoan(Guid id)
    {
        throw new NotImplementedException();
    }
}