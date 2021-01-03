using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dtos.MovieDtos;
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
        public IActionResult Create(CreateMovieDto movie)
        {
            try
            {
                _service.Create(movie);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok();
        }
   
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAll());
        }

        [HttpGet]
        [Route("{id?}")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _service.Get(id));
        }

        [HttpPut]
        public IActionResult Update(UpdateMovieDto movie)
        {
            try
            {
                _service.Update(movie);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok();
        }
    }
}

