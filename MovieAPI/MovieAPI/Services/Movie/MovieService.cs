using MovieAPI.Models;
using MovieAPI.Repositories;
using MovieAPI.Services;
using System.Collections.Generic;

namespace MovieAPI.Controllers
{
    public class MovieService : GenericService<Movie, int>
    {
        public MovieService(GenericRepository<Movie, int> repository) : base(repository)
        {
        }

        readonly MovieRepository repository = new MovieRepository();

    }
}