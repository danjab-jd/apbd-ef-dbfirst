namespace DbFirst.Models.DTO;

public class BookDTO
{
    public int Id { get; }

    public string Title { get; }

    public string PublishYear { get; }

    public BookDTO(int id, string title, string publishYear)
    {
        Id = id;
        Title = title;
        PublishYear = publishYear;
    }
}