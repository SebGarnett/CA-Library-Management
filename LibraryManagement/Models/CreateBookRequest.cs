namespace LibraryManagement.API.Models;

public class CreateBookRequest
{
    public string Name { get; set; }
    public Guid AuthorId { get; set; }
}