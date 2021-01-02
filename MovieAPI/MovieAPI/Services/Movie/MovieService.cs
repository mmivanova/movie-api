using MovieAPI.Models;
using MovieAPI.Repositories.Movie;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    public class MovieService : GenericService<Movie, int>, IMovieService
    {
        public MovieService(IMovieRepository repository) : base(repository)
        {
        }
    }
}