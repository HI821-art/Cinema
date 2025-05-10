using Microsoft.AspNetCore.Mvc;
using Core.Services;
using Data.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Cinema.Controllers
{
    
    [Route("Favorites")]
    public class FavoritesController : Controller
    {
        private readonly MovieDbContext _context;
        private readonly IFavoriteService _favService;

        public FavoritesController(MovieDbContext context, IFavoriteService favService)
        {
            _context = context;
            _favService = favService;
        }

       
        [HttpGet]
        public IActionResult Index()
        {
            var favoriteMovies = _favService.GetAll();
            return View(favoriteMovies);
        }

        
        [HttpGet("Details/{id}")]
        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        
        [HttpPost("Add/{id}")]
        public IActionResult Add(int id, string? returnUrl)
        {
            if (!_favService.GetIds().Contains(id))
            {
                _favService.Add(id);
            }
            return returnUrl != null ? Redirect(returnUrl) : RedirectToAction("Index", "Movies");
        }

       
        [HttpPost("Remove/{id}")]
        public IActionResult Remove(int id, string? returnUrl)
        {
            _favService.Remove(id);
            return returnUrl != null ? Redirect(returnUrl) : RedirectToAction("Index", "Movies");
        }


       
        [HttpGet("Count")]
        public IActionResult GetFavoriteCount()
        {
            var count = _favService.GetCount();
            return Json(new { count });
        }
    }
}