using CinemaximumClone.Data.Services.Repositories;
using CinemaximumClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data.Services
{
    public class CategoryService : RepositoryService<Category>, ICategoryService
    {
        public CategoryService(CinemaContext context) : base(context)
        {

        }
    }
}
