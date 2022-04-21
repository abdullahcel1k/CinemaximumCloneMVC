using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class City : BaseModel
    {
        public City()
        {
            Cinemas = new List<Cinema>();
        }
        public int Code { get; set; }
        public string Name { get; set; }
        public List<Cinema> Cinemas { get; set; }
    }
}
