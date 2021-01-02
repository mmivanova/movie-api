using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using MovieAPI.Services;
using System.Threading.Tasks;

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
