using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Repositories
{
    public interface IRepository<T, PK>
        where T : class 
       
    {
        // TODO: bool SaveChanges();

        IEnumerable<T> GetAll();
        T Get(PK id);
        void Create(T t);
        void Update(T t);
        void Delete(PK id);
    }
}
