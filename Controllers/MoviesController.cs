using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
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

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies
                .Include(m => m.Actors)
                .Include(m => m.Director)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
        public ActionResult Delete(int id)
        {
            var player = _context.Movies.Find(id);
            if (player == null) return NotFound();

            _context.Movies.Remove(player);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}