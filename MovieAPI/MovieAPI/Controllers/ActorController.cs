using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Repositories.Actor;
using MovieAPI.Services;
using Serilog;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : Controller
    {
        private static readonly ActorRepository actorRepository = new ActorRepository();
        readonly ActorService _service = new ActorService(actorRepository);

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
