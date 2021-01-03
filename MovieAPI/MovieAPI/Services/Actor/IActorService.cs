using MovieAPI.Dtos.ActorDtos;

namespace MovieAPI.Services
{
    public interface IActorService : IService<Models.Actor, int, BaseActorDto>
    {
    }
}
