using CinemaximumClone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.ViewModels
{
    public class CinemaIndexViewModel
    {
        public List<Cinema> Cinemas  { get; set; }
        public List<City> Cities { get; set; }
    }
}
