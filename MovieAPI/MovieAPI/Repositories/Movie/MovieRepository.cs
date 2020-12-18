using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using MovieAPI.Repositories;
using MovieAPI.Repositories.Movie;
using System.Collections.Generic;
using System.Linq;

namespace MovieAPI.Controllers
{
    public class MovieRepository : GenericRepository<Movie, int>, IMovieRepository
    {
        public MovieRepository()
        {
          
        }
    }
}