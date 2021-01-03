using MovieAPI.Dtos.ActorDtos;

namespace MovieAPI.Repositories.Actor
{
    public class ActorRepository : GenericRepository<Models.Actor, int, BaseActorDto>, IActorRepository
    {
        public ActorRepository()
        {
        }
    }
}

