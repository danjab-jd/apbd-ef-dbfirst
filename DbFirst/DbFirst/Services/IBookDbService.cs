using DbFirst.Models.DTO;

namespace DbFirst.Services;

public interface IBookDbService
{
    Task<IList<BookDTO>> GetBooksAsync(CancellationToken cancellationToken = default);
}