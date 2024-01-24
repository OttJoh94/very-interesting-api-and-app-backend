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
            new Movie {Id = 1, Title = "Lord of the Rings", Director = "Peter Jacksson", Description = "Epic adventure about a friendship turning into something more", Length = 178, ReleaseDate = new DateTime(2001, 12, 19), Rating = 8.9, Category = "Fantasy, Action"},
            new Movie {Id = 2, Title = "Harry Potter and the Sorcerer's Stone", Director = "Chris Columbus", Description = "Yerr a wizard, Harry", Length = 152, ReleaseDate = new DateTime(2001, 11, 23), Rating = 7.6, Category = "Adventure, Family, Fantasy"}
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
