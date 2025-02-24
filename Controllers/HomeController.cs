using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
                return View(new List<Movie>());
            }

            return View(movies);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
