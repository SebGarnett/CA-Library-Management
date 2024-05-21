namespace LibraryManagement.API.Models;

public class CreateLoanRequest
{
    public Guid BookId { get; set; }
    public Guid BorrowerId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime EndDate { get; set; }
}