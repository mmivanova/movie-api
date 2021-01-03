using MovieAPI.Dtos.MovieDtos;
using MovieAPI.Models;

namespace MovieAPI.Services
{
    public interface IMovieService : IService<Movie, int, BaseMovieDto>
    {
    }
}
