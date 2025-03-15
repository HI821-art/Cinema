namespace CINEMA.Entitties
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
    }
}
