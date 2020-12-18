using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieAPI.Models;
using MovieAPI.Services.Movie;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static readonly MovieRepository movieRepository = new MovieRepository();
        readonly MovieService _service = new MovieService(movieRepository);

        [HttpPost]
        public void Create([FromBody] Movie movie)
        {
            _service.Create(movie);
        }
   
        [HttpGet]
        [Route("all")]
        public IEnumerable<Movie> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("{id?}")]
        public Movie Get([FromQuery] int id)
        {
            return _service.Get(id);
        }

        [HttpPut]
        public void Update(

            [FromBody] Movie movie)
        {
            _service.Update(movie);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}

