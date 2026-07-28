using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Pages;

public class IndexModel : PageModel
{
    private readonly MovieDbContext _context;

    public IndexModel(MovieDbContext context)
    {
        _context = context;
    }

    public int TotalMovies { get; set; }
    public int AvailableMovies { get; set; }
    public int GenreCount { get; set; }

    public async Task OnGet()
    {
        var movies = await _context.Movies.AsNoTracking().ToListAsync();
        TotalMovies = movies.Count;
        AvailableMovies = movies.Count(m => m.IsAvailable);
        GenreCount = movies.Select(m => m.Genre).Distinct().Count();
    }
}
