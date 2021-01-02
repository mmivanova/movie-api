namespace MovieAPI.Repositories.Movie
{
    public class MovieRepository : GenericRepository<Models.Movie, int>, IMovieRepository
    {
        public MovieRepository()
        {
          
        }
    }
}