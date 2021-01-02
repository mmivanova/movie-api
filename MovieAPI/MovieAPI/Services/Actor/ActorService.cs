using MovieAPI.Models;
using MovieAPI.Repositories;
using MovieAPI.Repositories.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public class ActorService : GenericService<Actor, int>, IActorService
    {
        public ActorService(IActorRepository repository) : base(repository)
        {
        }
    }
}
