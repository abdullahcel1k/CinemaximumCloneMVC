using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.ViewModels
{
    public class HallViewModel
    {
        public string Name { get; set; }
        public int CinemaId { get; set; }
        public int Capacity { get; set; }
    }

    public class HallListViewModel
    {
        public int Id { get; set; }
        public string CinemaName { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public int Capacity { get; set; }
    }
}
