using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;

namespace CinemaximumClone.Data.Services
{
    public class CategoryService : RepositoryService<Category>, ICategoryService
    {
        public CategoryService(CinemaContext context) : base(context)
        {

        }
    }
}
