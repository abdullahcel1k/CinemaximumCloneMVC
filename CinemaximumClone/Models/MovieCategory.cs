using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class MovieCategory: BaseModel
    {
        public Movie Movie { get; set; }
        public Category Category { get; set; }
    }
}
