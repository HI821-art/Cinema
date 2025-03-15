namespace CINEMA.Entitties
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public ICollection<Seat>? Seats { get; set; } = new List<Seat>();
    }
}
