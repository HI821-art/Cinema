using Microsoft.AspNetCore.Http;
using Cinema.Data;
using Cinema.Entities;
using Cinema.Extensions;
using System.Collections.Generic;
using System.Linq;


namespace Cinema.Services
{
    public class FavoritesService
    {
        private readonly ISession _session;
        private readonly MovieDbContext _context;
        private const string key = "favourite_list";

        public FavoritesService(IHttpContextAccessor accessor, MovieDbContext context)
        {
            this._session = accessor.HttpContext?.Session ?? throw new ArgumentNullException(nameof(accessor.HttpContext));
            _context = context;
        }

        public List<int> GetIds()
        {
            return _session.Get<List<int>>(key) ?? new List<int>();
        }

        public List<Movie> GetAll()
        {
            var ids = GetIds();
            return _context.Movies.Where(x => ids.Contains(x.Id)).ToList();
        }

        public void Add(int id)
        {
            var ids = GetIds();

            if (ids.Contains(id)) return;

            ids.Add(id);
            _session.Set(key, ids);
        }

        public void Remove(int id)
        {
            var ids = GetIds();
            ids.Remove(id);
            _session.Set(key, ids);
        }

        public void Clear()
        {
            _session.Remove(key);
        }

        public int GetCount()
        {
            return GetIds().Count;
        }
    }
}