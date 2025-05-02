using System.ComponentModel.DataAnnotations;

namespace Cinema.DTOs;

public class MovieCreateDto
{
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters.", MinimumLength = 1)]
    public string Title { get; set; }

    [Required(ErrorMessage = "Year is required.")]
    [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
    public int Year { get; set; }

    [Required(ErrorMessage = "Description is required.")]
    [StringLength(1000, ErrorMessage = "Description must not exceed 1000 characters.")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Genre is required.")]
    [StringLength(50, ErrorMessage = "Genre must not exceed 50 characters.")]
    public string Genre { get; set; }

    [Required(ErrorMessage = "Duration is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than 0.")]
    public int Duration { get; set; }

    [Required(ErrorMessage = "Cover image is required.")]
    [StringLength(255, ErrorMessage = "Cover image URL must not exceed 255 characters.")]
    public string CoverImage { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    [StringLength(100, ErrorMessage = "Country must not exceed 100 characters.")]
    public string Country { get; set; }

    [Required(ErrorMessage = "Trailer URL is required.")]
    [Url(ErrorMessage = "Invalid URL format.")]
    public string TrailerUrl { get; set; }

    [Required(ErrorMessage = "Director ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "Director ID must be greater than 0.")]
    public int DirectorId { get; set; }
}

