namespace LibraryManagement.Application.LoanItems.Dtos;

public class LoanDto
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid BorrowerId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime EndDate { get; set; }
}
