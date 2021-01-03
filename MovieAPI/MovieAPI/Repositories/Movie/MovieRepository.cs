using MovieAPI.Dtos.MovieDtos;

namespace MovieAPI.Repositories.Movie
{
    public class MovieRepository : GenericRepository<Models.Movie, int, BaseMovieDto>, IMovieRepository
    {
        public MovieRepository()
        {
        }
    }
}