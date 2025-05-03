namespace Data.Entities
{
    public class AvailableSeatsModel
    {
        public int SessionId { get; set; }
        public IEnumerable<Seat> AvailableSeats { get; set; } = new List<Seat>();
        public int AvailableSeatsCount { get; set; }
    }
}