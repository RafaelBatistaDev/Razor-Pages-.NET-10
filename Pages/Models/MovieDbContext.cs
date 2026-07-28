using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data;

/// <summary>
/// Entity Framework Core database context for the Movie application.
/// </summary>
public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movies");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Title)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(e => e.Genre)
                  .IsRequired()
                  .HasMaxLength(50);

            entity.Property(e => e.Price)
                  .HasColumnType("decimal(18,2)");

            entity.Property(e => e.ReleaseDate)
                  .IsRequired();

            entity.Property(e => e.CreatedAt)
                  .HasDefaultValueSql("datetime('now')");

            entity.HasIndex(e => e.Title);
            entity.HasIndex(e => e.Genre);
        });

        // Seed data
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Title = "Interestelar",
                ReleaseDate = new DateTime(2014, 11, 6),
                Genre = "Ficção Científica",
                Price = 29.90m,
                Rating = 9.5,
                Director = "Christopher Nolan",
                DurationInMinutes = 169,
                AgeRating = "10",
                Description = "Uma equipe de exploradores viaja através de um buraco de minhoca no espaço em uma tentativa de garantir a sobrevivência da humanidade.",
                IsAvailable = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Movie
            {
                Id = 2,
                Title = "O Poderoso Chefão",
                ReleaseDate = new DateTime(1972, 3, 24),
                Genre = "Drama",
                Price = 24.90m,
                Rating = 9.7,
                Director = "Francis Ford Coppola",
                DurationInMinutes = 175,
                AgeRating = "14",
                Description = "O patriarca de uma poderosa família do crime transfere o controle de seu império para seu filho relutante.",
                IsAvailable = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            },
            new Movie
            {
                Id = 3,
                Title = "Matrix",
                ReleaseDate = new DateTime(1999, 5, 21),
                Genre = "Ação",
                Price = 19.90m,
                Rating = 9.3,
                Director = "Lana Wachowski, Lilly Wachowski",
                DurationInMinutes = 136,
                AgeRating = "14",
                Description = "Um hacker descobre que a realidade é uma simulação e se junta a rebeldes para lutar contra seus controladores.",
                IsAvailable = true,
                CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            }
        );
    }
}
