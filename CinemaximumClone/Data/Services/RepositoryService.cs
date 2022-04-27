using CinemaximumClone.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class RepositoryService<T> : IRepository<T> where T : class
    {
        private readonly CinemaContext _context;

        public RepositoryService(CinemaContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetList()
        {
            var list = await _context.Set<T>().ToListAsync();
            return list;
        }

        public async Task<T> Add(T entity)
        {
            var addedEntity = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<T> GetById(int id)
        {
            var findedEntity = await _context.Set<T>().FindAsync(id);
            return findedEntity;
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var deletedEntity = await GetById(id);
                _context.Set<T>().Remove(deletedEntity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<List<T>> FindList(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }
    }
}
