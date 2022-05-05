using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Repositories
{
    public interface IHallService : IRepository<Hall>
    {
        Task<List<HallListViewModel>> GetHallWithCity();
    }
}
