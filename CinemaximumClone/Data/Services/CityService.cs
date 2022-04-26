using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class CityService: RepositoryService<City>, ICityService
    {
        public CityService(CinemaContext context) : base(context)
        {

        }
    }
}
