using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class Cinema : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
    }
}
