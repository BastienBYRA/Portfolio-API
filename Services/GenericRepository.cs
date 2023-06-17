using Portfolio_API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Portfolio_API.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        private DbSet<T> Table = null;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            Table = _context.Set<T>();
        }

        public virtual void Add(T entity)
        {
            _context.Add(entity);
        }

        public virtual async void AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _context.AddRange(entities);
        }

        public virtual async void AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.AddRangeAsync(entities);
        }

        public virtual void Entry_Modified(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual async Task<List<T>> GetAll(int? page, int? numberPerPage)
        {
            int numberPage = (page ?? 1);
            int numberShowPerPage = (numberPerPage ?? 5);

            try
            {
                return await Table.Skip((numberPage - 1) * numberShowPerPage).Take(numberShowPerPage).ToListAsync();
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public virtual async Task<T> GetById(object id)
        {
            return await Table.FindAsync(id);
        }

        public virtual void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _context.RemoveRange(entities);
        }

        public virtual void Update(T entity)
        {
            _context.Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            _context.UpdateRange(entities);
        }
    }
}
