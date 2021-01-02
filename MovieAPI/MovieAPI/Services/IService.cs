using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IService<T, PK>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(PK id);
        void Update(T t);
        void Create(T t);
        void Delete(PK id);


    }
}
