using System.ComponentModel.DataAnnotations;

namespace Cinema.DTOs;
public class MovieCreateDto
{
    [Required]
    [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters.", MinimumLength = 1)]
    public string Title { get; set; }

    [Required]
    [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
    public int Year { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Genre { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than 0.")]
    public int Duration { get; set; }

    [Required]
    public string CoverImage { get; set; }

    [Required]
    public string Country { get; set; }

    [Url(ErrorMessage = "Invalid URL format.")]
    public string TrailerUrl { get; set; }
    public int DirectorId { get; set; }
}
