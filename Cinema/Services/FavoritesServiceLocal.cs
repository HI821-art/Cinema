using Microsoft.AspNetCore.Http;
using Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Core.Extensions;
using Core.Interfaces;
using Data.Entities;

namespace Cinema.Services;

public class FavoritesServiceLocal : IFavoriteService
{
    private readonly ISession _session;
    private readonly MovieDbContext _context;
    private const string Key = "favourite_list";

    public FavoritesServiceLocal(IHttpContextAccessor accessor, MovieDbContext context)
    {
        _session = accessor.HttpContext?.Session ?? throw new ArgumentNullException(nameof(accessor.HttpContext));
        _context = context;
    }

    public List<int> GetIds()
    {
        return _session.Get<List<int>>(Key) ?? new List<int>();
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
        _session.Set(Key, ids);
    }

    public void Remove(int id)
    {
        var ids = GetIds();
        ids.Remove(id);
        _session.Set(Key, ids);
    }

    public void Clear()
    {
        _session.Remove(Key);
    }

    public int GetCount()
    {
        return GetIds().Count;
    }
}
