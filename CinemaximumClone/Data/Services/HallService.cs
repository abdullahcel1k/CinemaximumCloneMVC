using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class HallService : RepositoryService<Hall>, IHallService
    {
        private readonly CinemaContext _context;
        public HallService(CinemaContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<HallListViewModel>> GetHallWithCity()
        {
            return await _context.Halls
                .Include(x => x.Chairs)
                .Include(h => h.Cinema)
                .ThenInclude(c => c.City)
                .Select(x => new HallListViewModel
                {
                    Id = x.Id,
                    CinemaName = x.Cinema.Name,
                    Name = x.Name,
                    Capacity = x.Chairs.Count,
                    CityName = x.Cinema.City.Name
                }).ToListAsync();

        }
    }
}
