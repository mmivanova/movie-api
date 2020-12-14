using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Repositories.Actor;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ActorController : Controller
    {
        private static ActorRepository actorRepository = new ActorRepository();
        ActorService actorService = new ActorService(actorRepository);
        
        [HttpPost]
        public void Create([FromBody] Actor actor)
        {
            actorService.Create(actor);
            Console.WriteLine(actor);
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Actor> GetAll()
        {
            return actorService.GetAll();
        }

        [HttpGet]
        [Route("{id?}")]
        public Actor Get([FromQuery] int id)
        {
            return actorService.Get(id);
        }

        [HttpPut]
        public void Update(

            [FromBody] Actor actor)
        {

            actorService.Update(actor);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            actorService.Delete(id);
        }
    }
}
