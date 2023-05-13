using DbFirst.Entities;
using DbFirst.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace DbFirst.Services;

public class BookDbService : IBookDbService
{
    private readonly ApbdDbContext _context;

    public BookDbService(ApbdDbContext context)
    {
        _context = context;
    }
    
    public async Task<IList<BookDTO>> GetBooksAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Books
            .Select(x => new BookDTO(x.IdBook, x.Title, x.PublishYear))
            .ToListAsync(cancellationToken);
    }
}