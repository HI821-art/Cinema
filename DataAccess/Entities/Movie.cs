using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Range(1888, int.MaxValue, ErrorMessage = "Year cannot be negative or less than 1888")]
        public int Year { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required string Genre { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than 0")]
        public int Duration { get; set; }

        [Required]
        public required string CoverImage { get; set; }

        [Required]
        public required string Country { get; set; }

        

        [Url(ErrorMessage = "Invalid URL format")]
        public required string TrailerUrl { get; set; }

        public ICollection<Actor>? Actors { get; set; } = new List<Actor>();

        [Required]
        public int DirectorId { get; set; }

        public Director? Director { get; set; }

        public ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();
    }
}
