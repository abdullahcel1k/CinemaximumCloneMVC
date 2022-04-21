using CinemaximumClone.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class RepositoryService<T> where T : class
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
    }
}
