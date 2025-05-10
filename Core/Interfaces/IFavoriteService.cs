using System.Collections.Generic;
using Data.Entities;

namespace Core.Interfaces
{
    public interface IFavoriteService
    {
        List<int> GetIds();
        List<Movie> GetAll();
        void Add(int id);
        void Remove(int id);
        void Clear();
        int GetCount();
    }
}
