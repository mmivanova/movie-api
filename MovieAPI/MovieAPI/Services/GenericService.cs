using AutoMapper;
using MovieAPI.Repositories;
using MovieAPI.Repositories.Actor;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public abstract class GenericService<T, PK, TDto> : IService<T, PK, TDto>
        where T : class
    {
        private readonly IRepository<T, PK, TDto> _repository;
        private readonly IMapper _mapper;

        public GenericService(IRepository<T, PK, TDto> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       
        public void Create(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _repository.Create(entity);
        }

        public void Delete(PK id)
        {
            _repository.Delete(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> Get(PK id)
        {
            return await _repository.Get(id);
        }

        public void Update(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            _repository.Update(entity);
        }

        
    }
}
