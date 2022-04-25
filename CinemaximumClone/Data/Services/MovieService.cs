using CinemaximumClone.Data.Services.Repositories;
using CinemaximumClone.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class MovieService : RepositoryService<Movie>, IMovieService
    {
        public MovieService(CinemaContext context): base(context)
        {

        }
    }
}
