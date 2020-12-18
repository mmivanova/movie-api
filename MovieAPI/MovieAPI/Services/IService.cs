using Microsoft.AspNetCore.Mvc;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    interface IService<T, PK>
    {
        IEnumerable<T> GetAll();
        T Get(PK id);
        void Update(T t);
        void Create(T t);
        void Delete(PK id);


    }
}
