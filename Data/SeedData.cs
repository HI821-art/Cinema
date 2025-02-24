using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cinema.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieDbContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                var actors = new[]
                {
                    new Actor { Name = "Leonardo DiCaprio", Biography = "An American actor, producer, and environmentalist." },
                    new Actor { Name = "Matt Damon", Biography = "An American actor, film producer, and screenwriter." },
                    new Actor { Name = "Robert Downey Jr.", Biography = "An American actor and producer." },
                    new Actor { Name = "Scarlett Johansson", Biography = "An American actress and singer." },
                    new Actor { Name = "Tom Hanks", Biography = "An American actor and filmmaker." }
                };

                var directors = new[]
                {
                    new Director { Name = "Christopher Nolan", Biography = "An English-American filmmaker known for his work on complex narratives." },
                    new Director { Name = "Steven Spielberg", Biography = "An American film director, screenwriter, and producer." },
                    new Director { Name = "Quentin Tarantino", Biography = "An American filmmaker and screenwriter." },
                    new Director { Name = "Martin Scorsese", Biography = "An American film director, producer, screenwriter, and actor." },
                    new Director { Name = "James Cameron", Biography = "A Canadian filmmaker and environmentalist." }
                };

                var movies = new[]
                {
                    new Movie
                    {
                        Title = "Inception",
                        Year = 2010,
                        Description = "A thief who steals corporate secrets through the use of dream-sharing technology.",
                        Genre = "Sci-Fi, Thriller",
                        Duration = 148,
                        CoverImage = "https://m.media-amazon.com/images/M/MV5BMjExMjkwNTQ0Nl5BMl5BanBnXkFtZTcwNTY0OTk1Mw@@._V1_.jpg",
                        Country = "USA",
                        TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0",
                        Director = directors[0],
                        DirectorId = 1,
                        Actors = new List<Actor> { actors[0], actors[1] }
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Year = 2008,
                        Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                        Genre = "Action, Crime, Drama",
                        Duration = 152,
                        CoverImage = "https://m.media-amazon.com/images/S/pv-target-images/e9a43e647b2ca70e75a3c0af046c4dfdcd712380889779cbdc2c57d94ab63902.jpg",
                        Country = "USA",
                        TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
                        Director = directors[0],
                        DirectorId = 1,
                        Actors = new List<Actor> { actors[0], actors[2] }
                    },
                    new Movie
                    {
                        Title = "Jurassic Park",
                        Year = 1993,
                        Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.",
                        Genre = "Adventure, Sci-Fi, Thriller",
                        Duration = 127,
                        CoverImage = "https://m.media-amazon.com/images/M/MV5BMjM2MDgxMDg0Nl5BMl5BanBnXkFtZTgwNTM2OTM5NDE@._V1_FMjpg_UX1000_.jpg",
                        Country = "USA",
                        TrailerUrl = "https://www.youtube.com/watch?v=lc0UehYemQA",
                        Director = directors[1],
                        DirectorId = 2,
                        Actors = new List<Actor> { actors[3], actors[4] }
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        Year = 1994,
                        Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                        Genre = "Crime, Drama",
                        Duration = 154,
                        CoverImage = "https://muzikercdn.com/uploads/products/8952/895213/6e77ddbb.JPG",
                        Country = "USA",
                        TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
                        Director = directors[2],
                        DirectorId = 3,
                        Actors = new List<Actor> { actors[0], actors[1] }
                    },
                    new Movie
                    {
                        Title = "Titanic",
                        Year = 1997,
                        Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                        Genre = "Drama, Romance",
                        Duration = 195,
                        CoverImage = "https://th.bing.com/th/id/OIP.w5yfrTQcJGzTVNmEVdYjuAHaEK?rs=1&pid=ImgDetMain",
                        Country = "USA",
                        TrailerUrl = "https://www.youtube.com/watch?v=kVrqfYjkTdQ",
                        Director = directors[4],
                        DirectorId = 5,
                        Actors = new List<Actor> { actors[0], actors[3] }
                    }
                };

                context.Actors.AddRange(actors);
                context.Directors.AddRange(directors);
                context.Movies.AddRange(movies);
                context.SaveChanges();
            }
        }
    }
}