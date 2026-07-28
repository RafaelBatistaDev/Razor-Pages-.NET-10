using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies;

public class DetailsModel : PageModel
{
    private readonly MovieDbContext _context;

    public DetailsModel(MovieDbContext context)
    {
        _context = context;
    }

    public Movie Movie { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await _context.Movies.AsNoTracking().FirstOrDefaultAsync(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }

        Movie = movie;
        return Page();
    }
}
