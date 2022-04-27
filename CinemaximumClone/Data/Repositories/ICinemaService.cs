
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Repositories
{
    public interface ICinemaService : IRepository<Cinema>
    {
        Task<List<CinemasTableViewModel>> GetCinemaAndCities(Expression<Func<Cinema, bool>> predicate);
    }
}
