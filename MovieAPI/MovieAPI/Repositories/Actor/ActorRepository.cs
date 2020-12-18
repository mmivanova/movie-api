using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Repositories.Actor
{
    public class ActorRepository : GenericRepository<Models.Actor, int>, IActorRepository
    {
        public ActorRepository()
        {
        }
    }
}

