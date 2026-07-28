using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies;

public class CreateModel : PageModel
{
    private readonly MovieDbContext _context;

    public CreateModel(MovieDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Movie Movie { get; set; } = new()
    {
        ReleaseDate = DateTime.Today,
        IsAvailable = true
    };

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Movie.CreatedAt = DateTime.UtcNow;
        Movie.UpdatedAt = null;

        _context.Movies.Add(Movie);
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = $"Filme \"{Movie.Title}\" cadastrado com sucesso!";
        return RedirectToPage("./Index");
    }
}
