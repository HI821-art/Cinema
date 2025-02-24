namespace Cinema.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public string CoverImage { get; set; }
        public string Country { get; set; }
        public string TrailerUrl { get; set; }

        public ICollection<Actor> Actors { get; set; } = new List<Actor>();
        public Director Director { get; set; }
        public int DirectorId { get; set; }
    }
}
