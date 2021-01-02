using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;

        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Create([FromBody] Movie movie)
        {
            _service.Create(movie);
        }
   
        [HttpGet]
        [Route("all")]
        public ActionResult<IEnumerable<Movie>> GetAll()
        {
            return _service.GetAll().ToList();
        }

        [HttpGet]
        [Route("{id?}")]
        public ActionResult<Movie> Get([FromQuery] int id)
        {
            return _service.Get(id);
        }

        [HttpPut]
        public void Update([FromBody] Movie movie)
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

