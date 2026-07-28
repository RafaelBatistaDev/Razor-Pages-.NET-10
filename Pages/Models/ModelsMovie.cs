using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

/// <summary>
/// Represents a movie entity with full CRUD support.
/// </summary>
public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O título é obrigatório.")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "O título deve ter entre 1 e 100 caracteres.")]
    [Display(Name = "Título")]
    public string Title { get; set; } = string.Empty;

    [Display(Name = "Data de Lançamento")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "A data de lançamento é obrigatória.")]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "O gênero é obrigatório.")]
    [StringLength(50, ErrorMessage = "O gênero deve ter no máximo 50 caracteres.")]
    [Display(Name = "Gênero")]
    public string Genre { get; set; } = string.Empty;

    [Required(ErrorMessage = "O preço é obrigatório.")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    [Range(0.01, 999999.99, ErrorMessage = "O preço deve estar entre 0.01 e 999.999,99.")]
    [Display(Name = "Preço")]
    public decimal Price { get; set; }

    [Display(Name = "Avaliação")]
    [Range(0, 10, ErrorMessage = "A avaliação deve estar entre 0 e 10.")]
    [RegularExpression(@"^[0-9]+(\.[0-9]{1,1})?$", ErrorMessage = "A avaliação deve ser um número com até uma casa decimal.")]
    public double? Rating { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
    [DataType(DataType.MultilineText)]
    public string? Description { get; set; }

    [Display(Name = "Diretor")]
    [StringLength(100, ErrorMessage = "O nome do diretor deve ter no máximo 100 caracteres.")]
    public string? Director { get; set; }

    [Display(Name = "Duração (minutos)")]
    [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 e 600 minutos.")]
    public int? DurationInMinutes { get; set; }

    [Display(Name = "Classificação Indicativa")]
    [StringLength(4, ErrorMessage = "A classificação indicativa deve ter no máximo 4 caracteres.")]
    public string? AgeRating { get; set; }

    [Display(Name = "Cadastrado em")]
    [DataType(DataType.DateTime)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Display(Name = "Atualizado em")]
    [DataType(DataType.DateTime)]
    public DateTime? UpdatedAt { get; set; }

    [Display(Name = "Disponível")]
    public bool IsAvailable { get; set; } = true;
}
