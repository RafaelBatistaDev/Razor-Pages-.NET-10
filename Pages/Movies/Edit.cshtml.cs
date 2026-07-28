using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies;

public class EditModel : PageModel
{
    private readonly MovieDbContext _context;

    public EditModel(MovieDbContext context)
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

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var movieToUpdate = await _context.Movies.FindAsync(Movie.Id);
        if (movieToUpdate == null)
        {
            return NotFound();
        }

        movieToUpdate.Title = Movie.Title;
        movieToUpdate.ReleaseDate = Movie.ReleaseDate;
        movieToUpdate.Genre = Movie.Genre;
        movieToUpdate.Price = Movie.Price;
        movieToUpdate.Rating = Movie.Rating;
        movieToUpdate.Director = Movie.Director;
        movieToUpdate.DurationInMinutes = Movie.DurationInMinutes;
        movieToUpdate.AgeRating = Movie.AgeRating;
        movieToUpdate.Description = Movie.Description;
        movieToUpdate.IsAvailable = Movie.IsAvailable;
        movieToUpdate.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = $"Filme \"{movieToUpdate.Title}\" atualizado com sucesso!";
        return RedirectToPage("./Index");
    }
}
