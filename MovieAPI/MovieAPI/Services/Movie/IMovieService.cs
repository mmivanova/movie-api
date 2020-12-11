using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services.Movie
{
    interface IMovieService : IService<Models.Movie, int>
    {
       
    }
}
