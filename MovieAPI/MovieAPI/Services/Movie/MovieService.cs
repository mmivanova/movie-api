using MovieAPI.Models;
using MovieAPI.Repositories;
using MovieAPI.Services;
using MovieAPI.Services.Movie;
using System.Collections.Generic;

namespace MovieAPI.Controllers
{
    public class MovieService : GenericService<Movie, int>, IMovieService
    {
        public MovieService(GenericRepository<Movie, int> repository) : base(repository)
        {
        }
    }
}