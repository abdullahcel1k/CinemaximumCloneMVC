using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.ViewModels
{
    public struct CinemasTableViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public int HallCount { get; set; }
    }
}
