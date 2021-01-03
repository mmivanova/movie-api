using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.Dtos.ActorDtos;
using MovieAPI.Models;
using MovieAPI.Services;
using System;
using System.Threading.Tasks;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _service;
        private readonly IMapper _mapper;

        public ActorController(IActorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Create(CreateActorDto createActorDto)
        {
            try
            {
                _service.Create(createActorDto);
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
        public IActionResult Update(UpdateActorDto actor)
        {
            try
            {
                _service.Update(actor);
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
            catch(Exception ex)
            {
                throw ex;
            }

            return Ok();
        }
    }
}
