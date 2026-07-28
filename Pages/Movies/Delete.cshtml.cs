using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies;

public class DeleteModel : PageModel
{
    private readonly MovieDbContext _context;

    public DeleteModel(MovieDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await _context.Movies.FindAsync(id);
        if (movie == null)
        {
            return NotFound();
        }

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = $"Filme \"{movie.Title}\" excluído com sucesso!";
        return RedirectToPage("./Index");
    }
}
