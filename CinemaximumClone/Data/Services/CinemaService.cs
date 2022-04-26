
using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;

namespace CinemaximumClone.Data.Services
{
    public class CinemaService : RepositoryService<Cinema>, ICinemaService
    {
        public CinemaService(CinemaContext context) : base(context)
        {

        }
    }
}
