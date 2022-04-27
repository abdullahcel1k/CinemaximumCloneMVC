using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class Cinema : BaseModel
    {
        public Cinema()
        {
            Halls = new List<Hall>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public City City { get; set; }
        public List<Hall> Halls  { get; set; }
    }
}
