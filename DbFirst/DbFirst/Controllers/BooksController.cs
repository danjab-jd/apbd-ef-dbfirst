using DbFirst.Models.DTO;
using DbFirst.Services;
using Microsoft.AspNetCore.Mvc;

namespace DbFirst.Controllers;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private readonly IBookDbService _bookDbService;

    public BooksController(IBookDbService bookDbService)
    {
        _bookDbService = bookDbService;
    }

    [HttpGet]
    public async Task<IActionResult> GetBooks(CancellationToken cancellationToken)
    {
        IList<BookDTO> books = await _bookDbService.GetBooksAsync(cancellationToken);
        return Ok(books);
    }
}