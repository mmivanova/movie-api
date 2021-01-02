using Microsoft.AspNetCore.Mvc;
using MovieAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Services
{
    public abstract class GenericService<T, PK> : IService<T, PK>
        where T : class
    {
        //private readonly GenericRepository<T, PK> _repository;
        private readonly IRepository<T, PK> _repository;

        public GenericService(IRepository<T, PK> repository)
        {
            _repository = repository;
        }

        public void Create(T t)
        {
            _repository.Create(t);
        }

        public void Delete(PK id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T Get(PK id)
        {
            return _repository.Get(id);
        }

        public void Update(T t)
        {
            _repository.Update(t);
        }

        
    }
}
