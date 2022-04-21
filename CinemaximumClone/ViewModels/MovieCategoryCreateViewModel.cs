using CinemaximumClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.ViewModels
{
    public class MovieCategoryCreateViewModel
    {
        public MovieCategoryCreateViewModel()
        {
            Categories = new List<Category>();
        }
        public Movie Movie { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
