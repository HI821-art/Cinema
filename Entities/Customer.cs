using System.ComponentModel.DataAnnotations;

namespace   Cinema.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        public ICollection<Ticket>? Tickets { get; set; } = new List<Ticket>();
    }
}

