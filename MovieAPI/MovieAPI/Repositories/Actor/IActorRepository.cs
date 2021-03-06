﻿using MovieAPI.Dtos.ActorDtos;

namespace MovieAPI.Repositories.Actor
{
    public interface IActorRepository : IRepository<Models.Actor, int, BaseActorDto>
    {
       
    }
}
