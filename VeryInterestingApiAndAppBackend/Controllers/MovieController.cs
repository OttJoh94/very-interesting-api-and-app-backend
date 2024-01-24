using Microsoft.AspNetCore.Mvc;
using VeryInterestingApiAndAppBackend.Models;

namespace VeryInterestingApiAndAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> Movies { get; set; } = new()
        {
            new Movie {
                Id = 1, Title = "Lord of the Rings",
                Director = "Peter Jacksson",
                Description = "Epic adventure about a friendship turning into something more",
                Length = 178,
                ReleaseDate = new DateTime(2001, 12, 19),
                Rating = 8.9,
                Category = "Fantasy, Action"
            },

            new Movie {
                Id = 2,
                Title = "Harry Potter and the Sorcerer's Stone",
                Director = "Chris Columbus",
                Description = "Yerr a wizard, Harry",
                Length = 152,
                ReleaseDate = new DateTime(2001, 11, 23),
                Rating = 7.6,
                Category = "Adventure, Family, Fantasy"
            },

            new Movie {
                Id = 3, Title = "Inception",
                Director = "Christopher Nolan",
                Description = "A dream within a dream within a dream",
                Length = 148,
                ReleaseDate = new DateTime(2010, 07, 23),
                Rating = 8.8,
                Category = "Action, Adventure, Sci-Fi. Thriller"
            },

            new Movie {
                Id = 4, Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Description = "Innocent man get's to prison and befriends Morgan Freeman",
                Length = 142,
                ReleaseDate = new DateTime(1995, 03, 03),
                Rating = 9.3,
                Category = "Drama"
            },

            new Movie {
                Id = 5, Title = "The Curious Case of Benjamin Button",
                Director = "David Fincher",
                Description = "A man starts aging backwards",
                Length = 166,
                ReleaseDate = new DateTime(2009, 01, 16),
                Rating = 7.8,
                Category = "Drama, Fantasy, Romance"
            },

            new Movie {
                Id = 6, Title = "Barbie",
                Director = "Greta Gerwig",
                Description = "Barbie being Barbie, Ken being Ken",
                Length = 116,
                ReleaseDate = new DateTime(2023, 07, 21),
                Rating = 6.9,
                Category = "Adventure, Comedy, Fantasy"
            },

            new Movie {
                Id = 7, Title = "Pulp Fiction",
                Director = "Quentin Tarantino",
                Description = "Girls like me don't make invitations like this to just anyone!",
                Length = 154,
                ReleaseDate = new DateTime(1994, 11, 25),
                Rating = 8.9,
                Category = "Crime, Drama"
            },

            new Movie {
                Id = 8, Title = "Titanic II",
                Director = "Shane Van Dyke",
                Description = "100 years after the original a new Titanic is build and hits an iceberg, but this time with sharks!",
                Length = 90,
                ReleaseDate = new DateTime(2010, 08, 24),
                Rating = 1.6,
                Category = "Action, Adventure, Thriller"
            },

            new Movie {
                Id = 9, Title = "Terminator",
                Director = "James Cameron",
                Description = "I'll be back",
                Length = 107,
                ReleaseDate = new DateTime(1985, 02, 08),
                Rating = 8.1,
                Category = "Action, Sci-Fi"
            },

            new Movie {
                Id = 10, Title = "Die Hard",
                Director = "John McTiernan",
                Description = "Yippee-Ki-Yay motherfucker!",
                Length = 132,
                ReleaseDate = new DateTime(1988, 09, 30),
                Rating = 8.2,
                Category = "Action, Thriller"
            },
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            Movie? movie = Movies.FirstOrDefault(m => m.Id == id);

            return movie != null ? Ok(movie) : NotFound("Can't find movie with that id");
        }

        [HttpPost]
        public ActionResult Post(Movie? movie)
        {
            if (movie == null)
            {
                return BadRequest("Inputs can't read as a movie");
            }
            else
            {
                Movies.Add(movie);
                return Ok("Successfully added movie");
            }
        }


    }
}
