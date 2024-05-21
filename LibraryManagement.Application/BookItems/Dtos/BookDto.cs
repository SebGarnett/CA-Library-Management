namespace LibraryManagement.Application.BookItems.Dtos;

public class BookDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid AuthorId { get; set; }
}