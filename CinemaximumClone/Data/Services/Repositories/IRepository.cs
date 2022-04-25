using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetList();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
    }
}
