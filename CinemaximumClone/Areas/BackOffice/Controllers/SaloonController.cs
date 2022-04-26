using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaximumClone.Areas.BackOffice.Controllers
{
    [Area("BackOffice")]
    public class SaloonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
