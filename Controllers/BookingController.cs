using Cinema.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class BookingController : Controller
{
    private readonly MovieDbContext _context;

    public BookingController(MovieDbContext context)
    {
        _context = context;
    }

   
    public async Task<IActionResult> AvailableSessions()
    {
        var sessions = await _context.Sessions
            .Include(s => s.Movie)
            .ToListAsync();
        return View(sessions);
    }

    public async Task<IActionResult> SelectSeats(int sessionId)
    {
        var session = await _context.Sessions
            .Include(s => s.Seats)
            .FirstOrDefaultAsync(s => s.Id == sessionId);

        if (session == null)
        {
            return NotFound();
        }

        return View(session);
    }

    
    [HttpPost]
    public async Task<IActionResult> BookSeat(int seatId, int customerId)
    {
        var seat = await _context.Seats.FirstOrDefaultAsync(s => s.Id == seatId);
        if (seat == null || seat.IsBooked)
        {
            return NotFound();
        }

        seat.IsBooked = true;
        var ticket = new Ticket
        {
            SeatId = seat.Id,
            CustomerId = customerId,
            PurchaseTime = DateTime.Now
        };

        _context.Tickets.Add(ticket);
        await _context.SaveChangesAsync();

        return RedirectToAction("TicketConfirmation", new { ticketId = ticket.Id });
    }

    
    public async Task<IActionResult> TicketConfirmation(int ticketId)
    {
        var ticket = await _context.Tickets
            .Include(t => t.Seat)
            .Include(t => t.Customer)
            .FirstOrDefaultAsync(t => t.Id == ticketId);

        if (ticket == null)
        {
            return NotFound();
        }

        return View(ticket);
    }
}
