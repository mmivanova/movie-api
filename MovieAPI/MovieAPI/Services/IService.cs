using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public interface IService<T, PK, TDto>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(PK id);
        void Update(TDto t);
        void Create(TDto t);
        void Delete(PK id);


    }
}
