﻿using MovieAPI.Dtos.MovieDtos;

namespace MovieAPI.Repositories.Movie
{
    public interface IMovieRepository : IRepository<Models.Movie, int, BaseMovieDto>
    {

    }
  
}
