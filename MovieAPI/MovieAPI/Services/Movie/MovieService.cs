using AutoMapper;
using MovieAPI.Dtos.MovieDtos;
using MovieAPI.Models;
using MovieAPI.Repositories.Movie;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    public class MovieService : GenericService<Movie, int, BaseMovieDto>, IMovieService
    {
        public MovieService(IMovieRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}