using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Repositories
{
    public interface IRepository<T, PK, TDto>
        where T : class 
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(PK id);
        void Create(T t);
        void Update(T t);
        void Delete(PK id);
    }
}
