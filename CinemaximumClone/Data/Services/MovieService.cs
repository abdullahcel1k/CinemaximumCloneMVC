using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;

namespace CinemaximumClone.Data.Services
{
    public class MovieService : RepositoryService<Movie>, IMovieService
    {
        public MovieService(CinemaContext context): base(context)
        {

        }
    }
}
