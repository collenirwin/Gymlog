using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    public class SavedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Workout()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Workout()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Exercise()
        {
            return View();
        }*/

        [HttpGet]
        public IActionResult Exercise()
        {
            return View();
        }
    }
}