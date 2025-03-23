using Microsoft.AspNetCore.Mvc;
using Cinema.Services;
using Cinema.Entities;

namespace Cinema.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly FavoritesService _favService;
        private readonly MovieDbContext _context;

        public FavoritesController(FavoritesService favService, MovieDbContext context)
        {
            _favService = favService;
            _context = context;
        }

        public ActionResult Index()
        {
            var favoriteMovies = _favService.GetAll();
            return View(favoriteMovies);
        }

        [HttpPost]
        public ActionResult Add(int id, string? returnUrl)
        {
            if (!_favService.GetIds().Contains(id))
            {
                _favService.Add(id);
            }
            return returnUrl != null ? Redirect(returnUrl) : RedirectToAction("Index", "Movies");
        }

        [HttpPost]
        public ActionResult Remove(int id, string? returnUrl)
        {
            _favService.Remove(id);
            return returnUrl != null ? Redirect(returnUrl) : RedirectToAction("Index", "Movies");
        }

        [HttpPost]
        public ActionResult ToggleFavorite(int id, string? returnUrl)
        {
            if (_favService.GetIds().Contains(id))
            {
                _favService.Remove(id);
            }
            else
            {
                _favService.Add(id);
            }
            return returnUrl != null ? Redirect(returnUrl) : RedirectToAction("Index", "Movies");
        }
    }
}