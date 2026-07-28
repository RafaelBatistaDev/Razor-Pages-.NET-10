using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies;

public class IndexModel : PageModel
{
    private readonly MovieDbContext _context;

    public IndexModel(MovieDbContext context)
    {
        _context = context;
    }

    public IList<Movie> Movie { get; set; } = new List<Movie>();

    [BindProperty(SupportsGet = true)]
    public string? SearchTitle { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SearchGenre { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? SearchRating { get; set; }

    [BindProperty(SupportsGet = true)]
    public int CurrentPage { get; set; } = 1;

    public int TotalPages { get; set; }
    public int TotalItems { get; set; }
    public const int PageSize = 8;

    public SelectList Genres { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // Populate genre filter dropdown
        var genres = await _context.Movies
            .Select(m => m.Genre)
            .Distinct()
            .OrderBy(g => g)
            .ToListAsync();

        Genres = new SelectList(genres);

        // Build query with filters
        var query = _context.Movies.AsQueryable();

        if (!string.IsNullOrWhiteSpace(SearchTitle))
        {
            query = query.Where(m => m.Title.Contains(SearchTitle));
        }

        if (!string.IsNullOrWhiteSpace(SearchGenre))
        {
            query = query.Where(m => m.Genre == SearchGenre);
        }

        if (!string.IsNullOrWhiteSpace(SearchRating) && double.TryParse(SearchRating, out var minRating))
        {
            query = query.Where(m => m.Rating >= minRating);
        }

        // Total items for pagination
        TotalItems = await query.CountAsync();
        TotalPages = (int)Math.Ceiling(TotalItems / (double)PageSize);
        TotalPages = Math.Max(1, TotalPages);

        if (CurrentPage < 1) CurrentPage = 1;
        if (CurrentPage > TotalPages) CurrentPage = TotalPages;

        // Fetch page
        Movie = await query
            .OrderByDescending(m => m.ReleaseDate)
            .Skip((CurrentPage - 1) * PageSize)
            .Take(PageSize)
            .AsNoTracking()
            .ToListAsync();
    }
}
