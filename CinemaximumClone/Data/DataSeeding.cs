using CinemaximumClone.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Data
{
    public static class DataSeeding
    {
        public static void Seed(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<CinemaContext>();
            context.Database.Migrate();


            if (context.Cities.Count() == 0)
            {
                context.Cities.AddRange(
                    new List<City>() {
                        new City(){ Name = "İstanbul", Code = 34 },
                        new City(){ Name = "Ankara", Code = 06 },
                        new City(){ Name = "Sivas", Code = 58 },
                        new City(){ Name = "Antalya", Code = 06 },
                        new City(){ Name = "Kayseri", Code = 38 },
                    }
                );
            }

            if(context.Cinemas.Count() == 0)
            {
                context.Cinemas.AddRange(
                   new List<Cinema>() {
                       new Cinema() { Name= "Brandium Cinemaximum", Description = "Cinemaximum brandium avm", City =context.Cities.Find(1) },
                       new Cinema() { Name= "Buyaka Cinemaximum", Description = "Cinemaximum Buyaka avm", City =context.Cities.Find(1) },
                       new Cinema() { Name= "Metropol Cinemaximum", Description = "Cinemaximum Metropol avm", City =context.Cities.Find(1) },
                   }
               );
            }

            context.SaveChanges();
        }

    }
}
