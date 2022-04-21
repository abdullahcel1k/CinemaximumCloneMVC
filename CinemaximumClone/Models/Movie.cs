using CinemaximumClone.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Models
{
    public class Movie : BaseModel
    {
        public Movie()
        {
            Comments = new List<Comment>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public DateTime VisionDate { get; set; }
        public int Duration { get; set; }
        public double StarRate { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
