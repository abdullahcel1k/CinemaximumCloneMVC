using CinemaximumClone.Data.Repositories;
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
        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
