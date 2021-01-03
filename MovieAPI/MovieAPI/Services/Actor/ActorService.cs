using AutoMapper;
using MovieAPI.Dtos.ActorDtos;
using MovieAPI.Repositories.Actor;

namespace MovieAPI.Services
{
    public class ActorService : GenericService<Models.Actor, int, BaseActorDto>, IActorService
    {
        public ActorService(IActorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
