﻿namespace CINEMA.Entitties
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Ticket>? Tickets { get; set; } = new List<Ticket>();
    }
}
