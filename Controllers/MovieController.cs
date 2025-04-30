using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300123
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController
    {
        private static List<string> stars1 = new List<string>
        {
            new string("James Caan"),
            new string("Al Pacinn"),
            new string("Robert Duvall")
        };

        private static List<string> stars2 = new List<string>
        {
            new string("Clancy Brown"),
            new string("Larry Brandenburg"),
            new string("Neil Giuntoli")
        };
        private static List<string> stars3 = new List<string>
        {
            new string("Brian Libby"),
            new string("David Provag"),
            new string("Joseph Ragnoi")
        };

        private static List<Movie> movie = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont",stars1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie ("The Godfather", "Francis Ford Coppola",stars2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie ("The Dark Knight", "Christopher Nolan",stars3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return movie;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movie[id];
        }

        [HttpPost]

        public void Post([FromBody] Movie value)
        {
            movie.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
                movie.RemoveAt(id);

        }
    }
}
