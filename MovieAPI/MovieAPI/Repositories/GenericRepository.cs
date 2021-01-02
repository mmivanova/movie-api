using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Repositories
{
    public abstract class GenericRepository<T, PK> : IRepository<T, PK>
        where T : class
    {
        private readonly APIDBContext _context = null;
        private readonly DbSet<T> table = null;

        protected GenericRepository()
        {
            _context = new APIDBContext();
            table = _context.Set<T>();
        }

        public void Create(T t)
        {
            table.Add(t);
            _context.SaveChanges();
        }

        public void Delete(PK id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            _context.SaveChanges();
        }

        public async Task<T> Get(PK id)
        {
            return table.Find(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return table.ToList();
        }

        public void Update(T t)
        {
            table.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
