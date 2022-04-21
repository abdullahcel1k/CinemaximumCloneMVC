using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class Comment : BaseModel
    {
        public string FullName { get; set; }
        public string Text { get; set; }
        public Movie Movie { get; set; }
    }
}
