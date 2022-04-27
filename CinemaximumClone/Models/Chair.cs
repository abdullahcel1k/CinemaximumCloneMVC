using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class Chair : BaseModel
    {
        public string No { get; set; }
        public Hall Hall { get; set; }
    }
}
