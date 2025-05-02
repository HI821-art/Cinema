using Cinema.Entities;
using Microsoft.EntityFrameworkCore;

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
                    new Actor { Name = "Tom Hanks", Biography = "An American actor and filmmaker." },
                    new Actor { Name = "Meryl Streep", Biography = "An American actress often described as the 'best actress of her generation'." },
                    new Actor { Name = "Denzel Washington", Biography = "An American actor, director, and producer." },
                    new Actor { Name = "Natalie Portman", Biography = "An Israeli-American actress known for her versatility." },
                    new Actor { Name = "Christian Bale", Biography = "A British actor known for his intense method acting." },
                    new Actor { Name = "Emma Stone", Biography = "An American actress known for her roles in comedies and dramas." },
                    new Actor { Name = "Brad Pitt", Biography = "An American actor and film producer." },
                    new Actor { Name = "Angelina Jolie", Biography = "An American actress, filmmaker, and humanitarian." },
                    new Actor { Name = "Morgan Freeman", Biography = "An American actor, director, and narrator." },
                    new Actor { Name = "Anne Hathaway", Biography = "An American actress known for her roles in romantic comedies and dramas." },
                    new Actor { Name = "Hugh Jackman", Biography = "An Australian actor, singer, and producer." },
                    new Actor { Name = "Jennifer Lawrence", Biography = "An American actress known for her roles in action and drama films." },
                    new Actor { Name = "Chris Hemsworth", Biography = "An Australian actor known for his role as Thor in the Marvel Cinematic Universe." },
                    new Actor { Name = "Gal Gadot", Biography = "An Israeli actress and model known for her role as Wonder Woman." },
                    new Actor { Name = "Ryan Reynolds", Biography = "A Canadian actor known for his comedic and action roles." },
                    new Actor { Name = "Viola Davis", Biography = "An American actress and producer known for her powerful performances." }
};
              

                var directors = new[]
                {
                    new Director { Name = "Christopher Nolan", Biography = "An English-American filmmaker known for his work on complex narratives." },
                    new Director { Name = "Steven Spielberg", Biography = "An American film director, screenwriter, and producer." },
                    new Director { Name = "Quentin Tarantino", Biography = "An American filmmaker and screenwriter." },
                    new Director { Name = "Martin Scorsese", Biography = "An American film director, producer, screenwriter, and actor." },
                    new Director { Name = "James Cameron", Biography = "A Canadian filmmaker and environmentalist." },
                    new Director { Name = "Ridley Scott", Biography = "An English film director and producer known for his work on science fiction and historical epics." },
                    new Director { Name = "Peter Jackson", Biography = "A New Zealand filmmaker known for directing 'The Lord of the Rings' trilogy." },
                    new Director { Name = "Alfred Hitchcock", Biography = "An English filmmaker widely regarded as one of the most influential figures in the history of cinema." },
                    new Director { Name = "Francis Ford Coppola", Biography = "An American film director, producer, and screenwriter known for 'The Godfather' trilogy." },
                    new Director { Name = "Guillermo del Toro", Biography = "A Mexican filmmaker known for his work on fantasy and horror films." },
                    new Director { Name = "Greta Gerwig", Biography = "An American actress and filmmaker known for her work on 'Lady Bird' and 'Barbie'." },
                    new Director { Name = "Denis Villeneuve", Biography = "A Canadian filmmaker known for 'Arrival', 'Blade Runner 2049', and 'Dune'." },
                    new Director { Name = "Wes Anderson", Biography = "An American filmmaker known for his distinctive visual and narrative style." },
                    new Director { Name = "Sofia Coppola", Biography = "An American filmmaker and actress known for 'Lost in Translation'." },
                    new Director { Name = "Patty Jenkins", Biography = "An American filmmaker known for directing 'Wonder Woman'." }
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
    CoverImage = "https://m.media-amazon.com/images/I/811lT7khIrL._AC_UF894,1000_QL80_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=kVrqfYjkTdQ",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[0], actors[3] }
},
new Movie
{
    Title = "The Matrix",
    Year = 1999,
    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
    Genre = "Action, Sci-Fi",
    Duration = 136,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BN2NmN2VhMTQtMDNiOS00NDlhLTliMjgtODE2ZTY0ODQyNDRhXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=vKQi3bBA1y8",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Gladiator",
    Year = 2000,
    Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
    Genre = "Action, Adventure, Drama",
    Duration = 155,
    CoverImage = "https://miro.medium.com/v2/resize:fit:1200/0*TxZdqJf0MQ2mdL9p.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=owK1qxDselE",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "The Lord of the Rings: The Fellowship of the Ring",
    Year = 2001,
    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
    Genre = "Action, Adventure, Drama",
    Duration = 178,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNzIxMDQ2YTctNDY4MC00ZTRhLTk4ODQtMTVlOWY4NTdiYmMwXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Lord of the Rings: The Two Towers",
    Year = 2002,
    Description = "While Frodo and Sam edge closer to Mordor with the help of the shifty Gollum, the divided fellowship makes a stand against Sauron's new ally, Saruman, and his hordes of Isengard.",
    Genre = "Action, Adventure, Drama",
    Duration = 179,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNzU2ODUxODgtNTdkYi00OTFmLWExNTctYWQ1NGVmYmQxNjMxXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=LbfMDwc4azU",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Lord of the Rings: The Return of the King",
    Year = 2003,
    Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
    Genre = "Action, Adventure, Drama",
    Duration = 201,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMWEyNGVkYWMtZThlNy00ZTY0LWExZWItOWE0YjM0MDU5YWY4XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=r5X-hFf6Bwo",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Shawshank Redemption",
    Year = 1994,
    Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
    Genre = "Drama",
    Duration = 142,
    CoverImage = "https://www.musiconvinyl.com/cdn/shop/files/MOVATM091_Sleeve.webp?v=1713507987&width=1445",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=6hB3S9bIaco",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Forrest Gump",
    Year = 1994,
    Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.",
    Genre = "Drama, Romance",
    Duration = 142,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNDYwNzVjMTItZmU5YS00YjQ5LTljYjgtMjY2NDVmYWMyNWFmXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=bLvqoHBptjg",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Godfather",
    Year = 1972,
    Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
    Genre = "Crime, Drama",
    Duration = 175,
    CoverImage = "https://play-lh.googleusercontent.com/ZucjGxDqQ-cHIN-8YA1HgZx7dFhXkfnz73SrdRPmOOHEax08sngqZMR_jMKq0sZuv5P7-T2Z2aHJ1uGQiys",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=sY1S34973zA",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Godfather: Part II",
    Year = 1974,
    Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed while his son, Michael, expands and tightens his grip on the family crime syndicate.",
    Genre = "Crime, Drama",
    Duration = 202,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMDIxMzBlZDktZjMxNy00ZGI4LTgxNDEtYWRlNzRjMjJmOGQ1XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=9O1Iy9od7-A",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Dark Knight Rises",
    Year = 2012,
    Description = "Eight years after the Joker's reign of anarchy, Batman, with the help of the enigmatic Catwoman, is forced from his exile to save Gotham City from the brutal guerrilla terrorist Bane.",
    Genre = "Action, Adventure",
    Duration = 164,
    CoverImage = "https://m.media-amazon.com/images/I/91HM6470jLL.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=g8evyE9TuYk",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Interstellar",
    Year = 2014,
    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
    Genre = "Adventure, Drama, Sci-Fi",
    Duration = 169,
    CoverImage = "https://beam-images.warnermediacdn.com/BEAM_LWM_DELIVERABLES/aa5b9295-8f9c-44f5-809b-3f2b84badfbf/8a7dd34b09c9c25336a3d850d4c431455e1aaaf0.jpg?host=wbd-images.prod-vod.h264.io&partner=beamcom",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Lion King",
    Year = 2019,
    Description = "After the murder of his father, a young lion prince flees his kingdom only to learn the true meaning of responsibility and bravery.",
    Genre = "Animation, Adventure, Drama",
    Duration = 118,
    CoverImage = "https://lumiere-a.akamaihd.net/v1/images/p_thelionking_19752_1_0b9de87b.jpeg?region=0%2C0%2C540%2C810",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=7TavVZMewpY",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
Title = "The Avengers",
Year = 2012,
Description = "Earth's mightiest heroes must come together and learn to fight as a team if they are to stop the mischievous Loki and his alien army from enslaving humanity.",
Genre = "Action, Adventure, Sci-Fi",
Duration = 143,
CoverImage = "https://m.media-amazon.com/images/M/MV5BNGE0YTVjNzUtNzJjOS00NGNlLTgxMzctZTY4YTE1Y2Y1ZTU4XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
Country = "USA",
TrailerUrl = "https://www.youtube.com/watch?v=eOrNdBpGMv8",
Director = directors[0],
DirectorId = 1,
Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
Title = "Avatar",
Year = 2009,
Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
Genre = "Action, Adventure, Fantasy",
Duration = 162,
CoverImage = "https://m.media-amazon.com/images/M/MV5BNmQxNjZlZTctMWJiMC00NGMxLWJjNTctNTFiNjA1Njk3ZDQ5XkEyXkFqcGc@._V1_.jpg",
Country = "USA",
TrailerUrl = "https://www.youtube.com/watch?v=5PSNL1qE6VY",
Director = directors[4],
DirectorId = 5,
Actors = new List<Actor> { actors[0], actors[1] }
},

new Movie
{
    Title = "Soul",
    Year = 2020,
    Description = "A musician who has lost his passion for music is transported out of his body and must find his way back with the help of an infant soul learning about herself.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 100,
    CoverImage = "https://cdn.kinocheck.com/i/p3dmrr9j0z.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=xOsLIiBStEs",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Luca",
    Year = 2021,
    Description = "On the Italian Riviera, an unlikely but strong friendship grows between a human being and a sea monster disguised as a human.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 95,
    CoverImage = "https://th.bing.com/th/id/OIP.Q8GfbEF5ooUkSOeOJMqEIAHaJ4?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=mYfJxlgR2jw",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "Raya and the Last Dragon",
    Year = 2021,
    Description = "In a realm known as Kumandra, a re-imagined Earth inhabited by an ancient civilization, a warrior named Raya is determined to find the last dragon.",
    Genre = "Animation, Action, Adventure",
    Duration = 107,
    CoverImage = "https://th.bing.com/th/id/OIP.gxDH-sFrzTtmqnaHoYVGVgHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=1VIZ89FEjYI",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[4], actors[0] }
},
new Movie
{
    Title = "Encanto",
    Year = 2021,
    Description = "A young Colombian girl has to face the frustration of being the only member of her family without magical powers.",
    Genre = "Animation, Comedy, Drama",
    Duration = 102,
    CoverImage = "https://i0.wp.com/intheplayroom.co.uk/wp-content/uploads/2022/01/Encanto_Doors_1s_Antonio_v3.4_KA_mech3_FS-scaled.jpg?w=1728&ssl=1",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=CaimKeDcudo",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[1], actors[2] }
},
new Movie
{
    Title = "The Mitchells vs the Machines",
    Year = 2021,
    Description = "A quirky, dysfunctional family's road trip is upended when they find themselves in the middle of the robot apocalypse and suddenly become humanity's unlikeliest last hope.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 113,
    CoverImage = "https://th.bing.com/th/id/OIP.3Lv6YQWCCN1Bz5yoikmaogHaKJ?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=_ak5dFt8Ar0",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[3], actors[4] }
},
new Movie
{
    Title = "Onward",
    Year = 2020,
    Description = "Two elven brothers embark on a quest to bring their father back for one day.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 102,
    CoverImage = "https://th.bing.com/th/id/OIP.AWxncTwXXnK0C1EazgtAawHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=gn5QmllRCn4",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Frozen II",
    Year = 2019,
    Description = "Anna, Elsa, Kristoff, Olaf, and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 103,
    CoverImage = "https://image.tmdb.org/t/p/original/mINJaa34MtknCYl5AjtNJzWj8cD.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=bwzLiQZDw2I",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "Spider-Man: Into the Spider-Verse",
    Year = 2018,
    Description = "Teen Miles Morales becomes the Spider-Man of his universe, and must join with five spider-powered individuals from other dimensions to stop a threat for all realities.",
    Genre = "Animation, Action, Adventure",
    Duration = 117,
    CoverImage = "https://th.bing.com/th/id/OIP.Gu-e4t8R9ws6RpxIEDCKdwHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[1], actors[2] }
},
new Movie
{
    Title = "Coco",
    Year = 2017,
    Description = "Aspiring musician Miguel, confronted with his family's ancestral ban on music, enters the Land of the Dead to find his great-great-grandfather, a legendary singer.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 105,
    CoverImage = "https://th.bing.com/th/id/R.06a039d56bb9932d0c7e50a52ef69ec7?rik=1O5NFF4UzK7IFA&pid=ImgRaw&r=0",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=Ga6RYejo6Hk",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[3], actors[4] }
},
new Movie
{
    Title = "Moana",
    Year = 2016,
    Description = "In Ancient Polynesia, when a terrible curse incurred by the Demigod Maui reaches Moana's island, she answers the Ocean's call to seek out the Demigod to set things right.",
    Genre = "Animation, Adventure, Comedy",
    Duration = 107,
    CoverImage = "https://th.bing.com/th/id/OIP.W_kbHrDuRIOLNZGFBTe_YgHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=LKFuXETZUsI",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Dune: Part Two",
    Year = 2023,
    Description = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.",
    Genre = "Action, Adventure, Drama",
    Duration = 155,
    CoverImage = "https://th.bing.com/th/id/OIP.zQGa2u3ra7dd_pDfEqDTewHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[0],
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Avatar 3",
    Year = 2024,
    Description = "The third installment of the 'Avatar' franchise.",
    Genre = "Action, Adventure, Sci-Fi",
    Duration = 162,
    CoverImage = "https://cdna.artstation.com/p/assets/images/images/031/645/214/large/shreyas-raut-avatar-2.jpg?1604210989",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Guardians of the Galaxy Vol. 3",
    Year = 2023,
    Description = "The Guardians of the Galaxy embark on a new adventure.",
    Genre = "Action, Adventure, Comedy",
    Duration = 150,
    CoverImage = "https://th.bing.com/th/id/OIP.4E32Anj4RLBR4T3KZGh9cgHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "The Flash",
    Year = 2023,
    Description = "Barry Allen uses his super speed to change the past, but his attempt to save his family creates a world without superheroes, forcing him to race for his life to save the future.",
    Genre = "Action, Adventure, Fantasy",
    Duration = 144,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BOGZjMjhhMDMtZjM5Ny00NGUyLThjNGYtNjJhZGJmMzMxYjllXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[4], actors[0] }
},
new Movie
{
    Title = "Indiana Jones 5",
    Year = 2023,
    Description = "The fifth installment of the 'Indiana Jones' franchise.",
    Genre = "Action, Adventure",
    Duration = 142,
    CoverImage = "https://th.bing.com/th/id/OIP.AyUdyPI6j_av_XpAjNtgYwHaJ4?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[1], actors[2] }
},
new Movie
{
    Title = "Mission: Impossible 8",
    Year = 2024,
    Description = "Ethan Hunt and his IMF team must track down a dangerous new weapon before it falls into the wrong hands.",
    Genre = "Action, Adventure, Thriller",
    Duration = 147,
    CoverImage = "https://th.bing.com/th/id/OIP.If52aHwONQaJ3zTWmOygVgHaK-?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[4],
    DirectorId = 5,
    Actors = new List<Actor> { actors[3], actors[4] }
},

new Movie
{
    Title = "Star Wars: Rogue Squadron",
    Year = 2023,
    Description = "The story will introduce a new generation of starfighter pilots as they earn their wings and risk their lives in a boundary-pushing, high-speed thrill ride.",
    Genre = "Action, Adventure, Sci-Fi",
    Duration = 140,
    CoverImage = "https://th.bing.com/th/id/OIP.iWOAnL6TDCPQUHk2rqmsagHaLH?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[1],
    DirectorId = 2,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "Black Panther: Wakanda Forever",
    Year = 2023,
    Description = "The people of Wakanda fight to protect their home from intervening world powers as they mourn the death of King T'Challa.",
    Genre = "Action, Adventure, Drama",
    Duration = 161,
    CoverImage = "https://th.bing.com/th/id/OIP.udstHPF8mPl8hm3gOsKkwQHaLQ?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[2],
    DirectorId = 3,
    Actors = new List<Actor> { actors[4], actors[0] }
},
new Movie
{
    Title = "The Batman 2",
    Year = 2025,
    Description = "The second installment of the new 'Batman' series.",
    Genre = "Action, Crime, Drama",
    Duration = 175,
    CoverImage = "https://th.bing.com/th/id/OIP.btQ1b0ZPeJVU1XQTqXxGvQHaJS?rs=1&pid=ImgDetMain",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=example",
    Director = directors[3],
    DirectorId = 4,
    Actors = new List<Actor> { actors[1], actors[2] }
},
new Movie
{
    Title = "The Social Network",
    Year = 2010,
    Description = "The story of the founding of Facebook and the legal battles that followed.",
    Genre = "Biography, Drama",
    Duration = 120,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMjlkNTE5ZTUtNGEwNy00MGVhLThmZjMtZjU1NDE5Zjk1NDZkXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=lB95KLmpLR4",
    Director = directors[3], // David Fincher (add if missing)
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "Parasite",
    Year = 2019,
    Description = "A poor family schemes to become employed by a wealthy family by infiltrating their household.",
    Genre = "Comedy, Drama, Thriller",
    Duration = 132,
    CoverImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcyJYd_sWzQdj87gwIiDRpi6JtzfY6-XLG-w&s",
    Country = "South Korea",
    TrailerUrl = "https://www.youtube.com/watch?v=5xH0HfJHsaY",
    Director = directors[5], // Bong Joon-ho (add if missing)
    DirectorId = 6,
    Actors = new List<Actor> { actors[2], actors[3] }
},
new Movie
{
    Title = "Whiplash",
    Year = 2014,
    Description = "A promising young drummer enrolls at a cutthroat music conservatory.",
    Genre = "Drama, Music",
    Duration = 107,
    CoverImage = "https://miro.medium.com/v2/resize:fit:1200/1*HygtAUSg3MqQjimu0MQy3Q.jpeg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=7d_jQycdQGo",
    Director = directors[6], // Damien Chazelle (add if missing)
    DirectorId = 7,
    Actors = new List<Actor> { actors[4], actors[5] }
},
new Movie
{
    Title = "Mad Max: Fury Road",
    Year = 2015,
    Description = "In a post-apocalyptic wasteland, Max teams up with Furiosa to escape a tyrannical warlord.",
    Genre = "Action, Adventure, Sci-Fi",
    Duration = 120,
    CoverImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMyIGN_1iegG9ECuta5TfEMsJ9aToEoaVKxQ&s",
    Country = "Australia",
    TrailerUrl = "https://www.youtube.com/watch?v=hEJnMQG9ev8",
    Director = directors[7], // George Miller (add if missing)
    DirectorId = 8,
    Actors = new List<Actor> { actors[6], actors[7] }
},
new Movie
{
    Title = "The Grand Budapest Hotel",
    Year = 2014,
    Description = "A concierge at a famous European hotel becomes embroiled in a murder mystery.",
    Genre = "Adventure, Comedy, Crime",
    Duration = 99,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMzM5NjUxOTEyMl5BMl5BanBnXkFtZTgwNjEyMDM0MDE@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=1Fg5iWmQjwk",
    Director = directors[8], // Wes Anderson
    DirectorId = 9,
    Actors = new List<Actor> { actors[8], actors[9] }
},
new Movie
{
    Title = "La La Land",
    Year = 2016,
    Description = "A jazz musician and an aspiring actress fall in love while pursuing their dreams in Los Angeles.",
    Genre = "Comedy, Drama, Music",
    Duration = 128,
    CoverImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHiNyIgZi__GIQH3571XA86KcN6MEdXLgjtg&s",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=0pdqf4P9MB8",
    Director = directors[6], // Damien Chazelle
    DirectorId = 7,
    Actors = new List<Actor> { actors[10], actors[11] }
},
new Movie
{
    Title = "The Irishman",
    Year = 2019,
    Description = "A mob hitman recalls his possible involvement with the slaying of Jimmy Hoffa.",
    Genre = "Biography, Crime, Drama",
    Duration = 209,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMTY2YThkNmQtOWJhYy00ZDc3LWEzOGEtMmQwNzM0YjFmZWIyXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=WHXxVmeGQUc",
    Director = directors[3], // Martin Scorsese
    DirectorId = 4,
    Actors = new List<Actor> { actors[12], actors[13] }
},
new Movie
{
    Title = "Joker",
    Year = 2019,
    Description = "A mentally troubled comedian embarks on a downward spiral that leads to the creation of an iconic villain.",
    Genre = "Crime, Drama, Thriller",
    Duration = 122,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNzY3OWQ5NDktNWQ2OC00ZjdlLThkMmItMDhhNDk3NTFiZGU4XkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=zAGVQLHvwOY",
    Director = directors[9], // Todd Phillips (add if missing)
    DirectorId = 10,
    Actors = new List<Actor> { actors[14], actors[15] }
},
new Movie
{
    Title = "The Wolf of Wall Street",
    Year = 2013,
    Description = "Based on the true story of Jordan Belfort, from his rise to a wealthy stockbroker to his fall involving crime and corruption.",
    Genre = "Biography, Comedy, Crime",
    Duration = 180,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMjIxMjgxNTk0MF5BMl5BanBnXkFtZTgwNjIyOTg2MDE@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=iszwuX1AK6A",
    Director = directors[3], // Martin Scorsese
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[16] }
},
new Movie
{
    Title = "Django Unchained",
    Year = 2012,
    Description = "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal plantation owner.",
    Genre = "Drama, Western",
    Duration = 165,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMjIyNTQ5NjQ1OV5BMl5BanBnXkFtZTcwODg1MDU4OA@@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=eUdM9vrCbow",
    Director = directors[2], // Quentin Tarantino
    DirectorId = 3,
    Actors = new List<Actor> { actors[17], actors[18] }
},
new Movie
{
    Title = "Shutter Island",
    Year = 2010,
    Description = "A U.S. Marshal investigates the disappearance of a murderer who escaped from a hospital for the criminally insane.",
    Genre = "Mystery, Thriller",
    Duration = 138,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BN2FjNWExYzEtY2YzOC00YjNlLTllMTQtNmIwM2Q1YzBhOWM1XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=5iaYLCiq5RM",
    Director = directors[3], // Martin Scorsese
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[1] }
},
new Movie
{
    Title = "The Prestige",
    Year = 2006,
    Description = "Two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",
    Genre = "Drama, Mystery, Sci-Fi",
    Duration = 130,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMjA4NDI0MTIxNF5BMl5BanBnXkFtZTYwNTM0MzY2._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=o4gHCmTQDVI",
    Director = directors[0], // Christopher Nolan
    DirectorId = 1,
    Actors = new List<Actor> { actors[0], actors[2] }
},
new Movie
{
    Title = "Fight Club",
    Year = 1999,
    Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more.",
    Genre = "Drama",
    Duration = 139,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BOTgyOGQ1NDItNGU3Ny00MjU3LTg2YWEtNmEyYjBiMjI1Y2M5XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=SUXWAEX2jlg",
    Director = directors[3], // David Fincher
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[3] }
},
new Movie
{
    Title = "The Silence of the Lambs",
    Year = 1991,
    Description = "A young FBI cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer.",
    Genre = "Crime, Drama, Thriller",
    Duration = 118,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNDdhOGJhYzctYzYwZC00YmI2LWI0MjctYjg4ODdlMDExYjBlXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=W6Mm8Sbe__o",
    Director = directors[10], // Jonathan Demme (add if missing)
    DirectorId = 11,
    Actors = new List<Actor> { actors[4], actors[5] }
},
new Movie
{
    Title = "The Green Mile",
    Year = 1999,
    Description = "The lives of guards on Death Row are affected by one of their charges: a black man accused of child murder and rape, yet who has a mysterious gift.",
    Genre = "Crime, Drama, Fantasy",
    Duration = 189,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMTUxMzQyNjA5MF5BMl5BanBnXkFtZTYwOTU2NTY3._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=Ki4haFrqSrw",
    Director = directors[11], // Frank Darabont (add if missing)
    DirectorId = 12,
    Actors = new List<Actor> { actors[6], actors[7] }
},
new Movie
{
    Title = "Saving Private Ryan",
    Year = 1998,
    Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.",
    Genre = "Drama, War",
    Duration = 169,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BZGZhZGQ1ZWUtZTZjYS00MDJhLWFkYjctN2ZlYjE5NWYwZDM2XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=RYID71hYHzg",
    Director = directors[1], // Steven Spielberg
    DirectorId = 2,
    Actors = new List<Actor> { actors[8], actors[9] }
},
new Movie
{
    Title = "The Departed",
    Year = 2006,
    Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
    Genre = "Crime, Drama, Thriller",
    Duration = 151,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMTI1MTY2OTIxNV5BMl5BanBnXkFtZTYwNjQ4NjY3._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=iojhqm0JTW4",
    Director = directors[3], // Martin Scorsese
    DirectorId = 4,
    Actors = new List<Actor> { actors[0], actors[10] }
},
new Movie
{
    Title = "The Truman Show",
    Year = 1998,
    Description = "An insurance salesman discovers his whole life is actually a reality TV show.",
    Genre = "Comedy, Drama",
    Duration = 103,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BNzA3ZjZlNzYtMTdjMy00NjMzLTk5ZGYtMTkyYzNiOGM1YmM3XkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=dlnmQbPGuls",
    Director = directors[12], // Peter Weir (add if missing)
    DirectorId = 13,
    Actors = new List<Actor> { actors[11], actors[12] }
},
new Movie
{
    Title = "The Revenant",
    Year = 2015,
    Description = "A frontiersman on a fur trading expedition fights for survival after being mauled by a bear and left for dead by members of his own hunting team.",
    Genre = "Action, Adventure, Drama",
    Duration = 156,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BYTgwNmQzZDctMjNmOS00OTExLTkwM2UtNzJmOTJhODFjOTdlXkEyXkFqcGc@._V1_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=LoebZZ8K5N0",
    Director = directors[13], // Alejandro G. Iñárritu (add if missing)
    DirectorId = 14,
    Actors = new List<Actor> { actors[0], actors[13] }
},
new Movie
{
    Title = "The Hateful Eight",
    Year = 2015,
    Description = "In the dead of a Wyoming winter, a bounty hunter and his prisoner find shelter in a cabin currently inhabited by a collection of nefarious characters.",
    Genre = "Crime, Drama, Mystery",
    Duration = 168,
    CoverImage = "https://m.media-amazon.com/images/M/MV5BMjA1MTc1NTg5NV5BMl5BanBnXkFtZTgwOTM2MDEzNzE@._V1_FMjpg_UX1000_.jpg",
    Country = "USA",
    TrailerUrl = "https://www.youtube.com/watch?v=6_UI1GzaWv0",
    Director = directors[2], // Quentin Tarantino
    DirectorId = 3,
    Actors = new List<Actor> { actors[14], actors[15] }
}




};
  
                var customers = new[]
              {
                    new Customer { Name = "Customer 1", Email = "customer1@example.com" },
                    new Customer { Name = "Customer 2", Email = "customer2@example.com" },
                    new Customer { Name = "Customer 3", Email = "customer3@example.com" },
                    new Customer { Name = "Customer 4", Email = "customer4@example.com" },
                    new Customer { Name = "Customer 5", Email = "customer5@example.com" },
                    new Customer { Name = "Customer 6", Email = "customer6@example.com" },
                    new Customer { Name = "Customer 7", Email = "customer7@example.com" },
                    new Customer { Name = "Customer 8", Email = "customer8@example.com" },
                    new Customer { Name = "Customer 9", Email = "customer9@example.com" },
                    new Customer { Name = "Customer 10", Email = "customer10@example.com" },
                    new Customer { Name = "Customer 11", Email = "customer11@example.com" },
                    new Customer { Name = "Customer 12", Email = "customer12@example.com" },
                    new Customer { Name = "Customer 13", Email = "customer13@example.com" },
                    new Customer { Name = "Customer 14", Email = "customer14@example.com" },
                    new Customer { Name = "Customer 15", Email = "customer15@example.com" },
                    new Customer { Name = "Customer 16", Email = "customer16@example.com" },
                    new Customer { Name = "Customer 17", Email = "customer17@example.com" },
                    new Customer { Name = "Customer 18", Email = "customer18@example.com" },
                    new Customer { Name = "Customer 19", Email = "customer19@example.com" },
                    new Customer { Name = "Customer 20", Email = "customer20@example.com" }
                };

                var sessions = new[]
{
    new Session
    {
        StartTime = DateTime.Now.AddHours(1),
        Movie = movies[0],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 3 == 0 // Every third seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(2),
        Movie = movies[1],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 4 == 0 // Every fourth seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(3),
        Movie = movies[2],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = false // All seats are available
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(4),
        Movie = movies[3],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 2 == 0 // Every second seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(5),
        Movie = movies[4],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i == 1 || i == 50 // Only the first and last seats are reserved
        }).ToList()
    },
    // Additional sessions
    new Session
    {
        StartTime = DateTime.Now.AddHours(6),
        Movie = movies[5],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 5 == 0 // Every fifth seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(7),
        Movie = movies[6],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = false // All seats are available
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(8),
        Movie = movies[7],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 6 == 0 // Every sixth seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(9),
        Movie = movies[8],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 7 == 0 // Every seventh seat is reserved
        }).ToList()
    },
    new Session
    {
        StartTime = DateTime.Now.AddHours(10),
        Movie = movies[9],
        Seats = Enumerable.Range(1, 50).Select(i => new Seat
        {
            SeatNumber = i.ToString(),
            IsBooked = i % 2 != 0 // Every odd seat is reserved
        }).ToList()
    }
};


                context.Actors.AddRange(actors);
                context.Directors.AddRange(directors);
                context.Movies.AddRange(movies);
                context.Customers.AddRange(customers);
                context.Sessions.AddRange(sessions);
                context.SaveChanges();
            }
}
}
}