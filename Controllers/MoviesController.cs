using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using AutoMapper;
using Cinema.Entities;
using Cinema.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _context;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public MoviesController(MovieDbContext context, IEmailSender emailSender, IMapper mapper)
        {
            _context = context;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(m => m.Director).ToListAsync();
            return View(movies);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var movie = await _context.Movies
                .Include(m => m.Director)
                .Include(m => m.Actors)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null) return NotFound();

            return View(movie);
        }

        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(new[] { "Action", "Drama", "Comedy", "Horror", "Sci-Fi" });
            ViewBag.Countries = new SelectList(new[] { "USA", "UK", "Canada", "Australia", "India" });
            ViewBag.Directors = new SelectList(_context.Directors, "Id", "Name");
            ViewBag.Actors = new MultiSelectList(_context.Actors, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MovieCreateDto movieDto, int[] selectedActors)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Genres = new SelectList(new[] { "Action", "Drama", "Comedy", "Horror", "Sci-Fi" });
                ViewBag.Countries = new SelectList(new[] { "USA", "UK", "Canada", "Australia", "India" });
                ViewBag.Directors = new SelectList(_context.Directors, "Id", "Name", movieDto.DirectorId);
                ViewBag.Actors = new MultiSelectList(_context.Actors, "Id", "Name", selectedActors);
                return View(movieDto);
            }

            var movie = _mapper.Map<Movie>(movieDto);
            movie.Actors = new List<Actor>();

            foreach (var actorId in selectedActors)
            {
                var actor = await _context.Actors.FindAsync(actorId);
                if (actor != null)
                {
                    movie.Actors.Add(actor);
                }
            }

            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var movie = await _context.Movies
                .Include(m => m.Actors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null) return NotFound();

            var movieDto = _mapper.Map<MovieEditDto>(movie);

            ViewBag.Genres = new SelectList(new[] { "Action", "Drama", "Comedy", "Horror", "Sci-Fi" }, movie.Genre);
            ViewBag.Countries = new SelectList(new[] { "USA", "UK", "Canada", "Australia", "India" }, movie.Country);
            ViewBag.Directors = new SelectList(_context.Directors, "Id", "Name", movie.DirectorId);
            ViewBag.Actors = new MultiSelectList(_context.Actors, "Id", "Name", movie.Actors.Select(a => a.Id));
            return View(movieDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MovieEditDto movieDto, int[] selectedActors)
        {
            if (id != movieDto.Id) return NotFound();

            if (!ModelState.IsValid)
            {
                ViewBag.Genres = new SelectList(new[] { "Action", "Drama", "Comedy", "Horror", "Sci-Fi" }, movieDto.Genre);
                ViewBag.Countries = new SelectList(new[] { "USA", "UK", "Canada", "Australia", "India" }, movieDto.Country);
                ViewBag.Directors = new SelectList(_context.Directors, "Id", "Name", movieDto.DirectorId);
                ViewBag.Actors = new MultiSelectList(_context.Actors, "Id", "Name", selectedActors);
                return View(movieDto);
            }

            var movieToUpdate = await _context.Movies
                .Include(m => m.Actors)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movieToUpdate == null) return NotFound();

            _mapper.Map(movieDto, movieToUpdate);

            movieToUpdate.Actors.Clear();
            foreach (var actorId in selectedActors)
            {
                var actor = await _context.Actors.FindAsync(actorId);
                if (actor != null)
                {
                    movieToUpdate.Actors.Add(actor);
                }
            }

            _context.Update(movieToUpdate);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var movie = await _context.Movies.FindAsync(id);

            if (movie == null) return NotFound();

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NoContent();

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}

