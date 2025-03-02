using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cinema.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieDbContext _context;

        public HomeController(MovieDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                .Include(m => m.Actors)
                .Include(m => m.Director)
                .ToListAsync();

            if (movies == null || !movies.Any())
            {
                return View(new List<Movies>());
            }

            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}