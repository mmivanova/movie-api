using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static MovieRepository movieRepository = new MovieRepository();
        MovieService movieService = new MovieService(movieRepository);

        [HttpPost]
        public void Create([FromBody] Movie movie)
        {
            movieService.Create(movie);
        }
   
        [HttpGet]
        [Route("all")]
        public IEnumerable<Movie> GetAll()
        {
            return movieService.GetAll();
        }

        [HttpGet]
        [Route("{id?}")]
        public Movie Get([FromQuery] int id)
        {
            return movieService.Get(id);
        }

        [HttpPut]
        public void Update(

            [FromBody] Movie movie)
        {
            movieService.Update(movie);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            movieService.Delete(id);
        }
    }
}

