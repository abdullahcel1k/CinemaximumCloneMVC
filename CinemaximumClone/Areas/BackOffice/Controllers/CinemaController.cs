using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Areas.BackOffice.Controllers
{
    [Area("BackOffice")]
    public class CinemaController : Controller
    {
        private readonly ICinemaService _cinemaService;
        private readonly ICityService _cityService;

        public CinemaController(ICinemaService cinemaService, ICityService cityService)
        {
            _cinemaService = cinemaService;
            _cityService = cityService;
        }

        public async Task<IActionResult> Index(List<int> city)
        {
            ViewBag.Cities = await _cityService.GetList();
            var cinemaTableList = new List<CinemasTableViewModel>(); ;
            if (city.Count > 0)
            {
                ViewBag.SelectedCities = city;
                cinemaTableList = await _cinemaService
                                    .GetCinemaAndCities(x => city.Contains(x.City.Code) && !x.IsDelete);
            }
            else
            {
                cinemaTableList = await _cinemaService
                                       .GetCinemaAndCities(x => !x.IsDelete);

            }
            return View(cinemaTableList);
        }

        public async Task<IActionResult> Detail(int id)
        {
            return View(await _cinemaService.GetById(id));
        }

        [HttpPost]
        public async Task<Cinema> SaveCinema([FromBody] SaveCinemaViewModel saveCinema)
        {
            Cinema cinema = new Cinema();
            cinema.Name = saveCinema.Name;
            cinema.Description = saveCinema.Description;
            cinema.City = await _cityService.GetById(saveCinema.CityId);
            return await _cinemaService.Add(cinema);
        }

        [HttpPost]
        public async Task<City> SaveCity([FromBody] City city)
        {
            return await _cityService.Add(city);
        }

        public async Task<List<Cinema>> GetCinemas()
        {
            return await _cinemaService.GetList();
        }

        public async Task<List<City>> GetCities()
        {
            return await _cityService.GetList();
        }

        [HttpDelete]
        public async Task<bool> DeleteCinema(int id)
        {
            return await _cinemaService.Delete(id);
        }

        [HttpDelete]
        public async Task<bool> DeleteCity(int id)
        {
            return await _cityService.Delete(id);
        }
    }
}
