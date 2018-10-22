using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using Gymlog.Models;
using Gymlog.Exercise;
using Microsoft.Extensions.Configuration;





// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gymlog.Controllers
{

    public class WorkoutController : Controller
    {
        private readonly IConfiguration configuration;
        public WorkoutController(IConfiguration config)
        {
            this.configuration = config;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.WorkoutFormModel model)
        {
            ExerciseData ED = new ExerciseData(configuration);
            var username = User.Identity.Name;
            username = username.ToUpper();
            return Content($"Test: {model.Exercise} {username}");
        }

        [HttpPost]
        public IActionResult InsertData(WorkoutFormModel exercise)
        {
            ExerciseData ED = new ExerciseData(configuration);
            var username = User.Identity.Name;
            username = username.ToUpper();

            int uID = ED.AddUser(exercise);
            exercise.Id = uID;

            return View(exercise);
        }

        [HttpPost]
        public IActionResult AddWorkout([FromBody]WorkoutFormModel exercise)
        {

            var username = User.Identity.Name;
            if (username != null)
            {
                username = username.ToUpper();
                var rows = exercise.Rows;
                return Content($"Testzz {rows}");
            }
            return View();
        }



    }
}
