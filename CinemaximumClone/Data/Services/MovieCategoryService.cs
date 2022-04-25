using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;

namespace CinemaximumClone.Data.Services
{
    public class MovieCategoryService : RepositoryService<MovieCategory> , IMovieCategoryService
    {
        public MovieCategoryService(CinemaContext context) : base(context)
        {

        }
    }
}
