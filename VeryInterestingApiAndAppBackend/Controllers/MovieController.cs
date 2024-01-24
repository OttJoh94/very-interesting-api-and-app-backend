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
