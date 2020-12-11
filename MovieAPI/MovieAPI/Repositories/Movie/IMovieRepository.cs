using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAPI.Models;

namespace MovieAPI.Repositories.Movie
{
    interface IMovieRepository : IRepository<Models.Movie, int>
    {

    }
  
}
