namespace CINEMA.Entitties
{
    public class Seat
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public Session? Session { get; set; }
        public string SeatNumber { get; set; }
        public bool IsBooked { get; set; }
    }
}
