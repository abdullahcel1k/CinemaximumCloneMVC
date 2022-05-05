using CinemaximumClone.Data.Repositories;
using CinemaximumClone.Models;
using CinemaximumClone.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Areas.BackOffice.Controllers
{
    [Area("BackOffice")]
    public class HallController : Controller
    {
        private readonly IHallService _hallService;
        private readonly IChairService _chairService;
        private readonly ICinemaService _cinemaService;
        public HallController(IHallService hallService, 
            IChairService chairService,
            ICinemaService cinemaService)
        {
            _hallService = hallService;
            _chairService = chairService;
            _cinemaService = cinemaService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Cinemas = await _cinemaService.GetList();
            return View();
        }

        public async Task<List<HallListViewModel>> GetHalls()
        {
            return await _hallService.GetHallWithCity();
        }

        [HttpPost]
        public async Task<Hall> Save([FromBody]HallViewModel hall)
        {
            var newHall = new Hall();
            newHall.Name = hall.Name;
            newHall.Cinema = await _cinemaService.GetById(hall.CinemaId);
            var addedHall = _hallService.Add(newHall);
            for(var i = 1; i <= hall.Capacity; i++)
            {
                var newChair = new Chair();
                newChair.Hall = addedHall.Result;
                newChair.No = i.ToString();
                await _chairService.Add(newChair);  
            }

            return addedHall.Result;
        }
    }
}
