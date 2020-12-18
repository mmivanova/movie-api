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
        private readonly GenericRepository<T, PK> repository;

        public GenericService(GenericRepository<T, PK> repository)
        {
            this.repository = repository;
        }

        public void Create(T t)
        {
            repository.Create(t);
        }

        public void Delete(PK id)
        {
            repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public T Get(PK id)
        {
            return repository.Get(id);
        }

        public void Update(T t)
        {
            repository.Update(t);
        }

        
    }
}
