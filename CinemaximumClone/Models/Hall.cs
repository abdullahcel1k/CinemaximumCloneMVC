using CinemaximumClone.Models.Abstracts;
using System.Collections.Generic;

namespace CinemaximumClone.Models
{
    public class Hall : BaseModel
    {
        public Hall()
        {
            Chairs = new List<Chair>();
        }

        public string Name { get; set; }
        public Cinema Cinema { get; set; }
        public List<Chair> Chairs  { get; set; }
    }
}
