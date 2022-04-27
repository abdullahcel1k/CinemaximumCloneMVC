using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetList();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<bool> Delete(int id);
        Task<List<T>> FindList(Expression<Func<T, bool>> predicate);
    }
}
