
using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class CinemaService : RepositoryService<Cinema>, ICinemaService
    {
        private readonly CinemaContext _context;
        public CinemaService(CinemaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<CinemasTableViewModel>> GetCinemaAndCities(Expression<Func<Cinema, bool>> predicate)
        {
            return await _context.Cinemas
                            .Where(predicate)
                            .Include(x => x.City)
                            .Select(c => 
                            new CinemasTableViewModel()
                            { 
                                Id = c.Id, 
                                Name = c.Name, 
                                CityName = c.City.Name, 
                                HallCount = c.Halls.Count 
                            })
                            .ToListAsync();
        }
    }
}
