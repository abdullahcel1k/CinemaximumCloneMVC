using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class HallService : RepositoryService<Hall>, IHallService
    {
        public HallService(CinemaContext context) : base(context)
        {

        }
    }
}
