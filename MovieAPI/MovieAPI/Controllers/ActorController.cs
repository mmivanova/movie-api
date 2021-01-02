using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Services;
using MovieAPI.Repositories;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _service;

        public ActorController(IActorService service)
        {
            _service = service;
        }

        [HttpPost]
        public void Create([FromBody] Actor actor)
        {
            _service.Create(actor);
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Actor> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet]
        [Route("{id?}")]
        public Actor Get([FromQuery] int id)
        {
            return _service.Get(id);
        }

        [HttpPut]
        public void Update(

            [FromBody] Actor actor)
        {
            _service.Update(actor);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
