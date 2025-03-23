using System.ComponentModel.DataAnnotations;

namespace Cinema.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required]
        public DateTime PurchaseTime { get; set; }
    }
}

