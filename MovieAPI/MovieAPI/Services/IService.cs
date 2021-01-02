using System.Collections.Generic;

namespace MovieAPI.Services
{
    public interface IService<T, PK>
    {
        IEnumerable<T> GetAll();
        T Get(PK id);
        void Update(T t);
        void Create(T t);
        void Delete(PK id);


    }
}
