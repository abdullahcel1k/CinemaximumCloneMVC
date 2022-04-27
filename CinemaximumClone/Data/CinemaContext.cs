using CinemaximumClone.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaximumClone.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) 
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Hall> Halls { get; set; }
    }
}
