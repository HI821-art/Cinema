﻿namespace CINEMA.Entitties
    {
        public class Ticket
        {
            public int Id { get; set; }
            public int SeatId { get; set; }
            public Seat Seat { get; set; }
            public int CustomerId { get; set; }
            public Customer Customer { get; set; }
            public DateTime PurchaseTime { get; set; }
        }
    }
