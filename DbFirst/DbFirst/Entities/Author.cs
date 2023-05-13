namespace DbFirst.Entities;

public partial class Author
{
    public int IdAuthor { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
