using System.ComponentModel.DataAnnotations;

namespace Cinema.Entities
{
    public class Seat
    {
        public int Id { get; set; }

        [Required]
        public int SessionId { get; set; }
        public Session? Session { get; set; }

        [Required]
        public string SeatNumber { get; set; }

        public bool IsBooked { get; set; }
    }
}

