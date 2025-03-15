using System.ComponentModel.DataAnnotations;

namespace CINEMA.Entitties
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Year cenn not be negative")]
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string CoverImage { get; set; }
        public string Country { get; set; }
        public string TrailerUrl { get; set; }
        public ICollection<Actor>? Actors { get; set; } = new List<Actor>();
        public Director? Director { get; set; }
        public int DirectorId { get; set; }
    }
}