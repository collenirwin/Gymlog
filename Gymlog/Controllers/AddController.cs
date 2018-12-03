using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;
using Gymlog.Models;
//using Gymlog.Exercise;
using Microsoft.Extensions.Configuration;
using Gymlog.Services;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gymlog.Controllers
{

    public class AddController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ExerciseService _exerciseService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly WorkoutService _workoutService;

        public AddController(IConfiguration config,
            ExerciseService exerciseService, UserManager<ApplicationUser> userManager,
            WorkoutService workoutService)
        {
            _config = config;
            _exerciseService = exerciseService;
            _workoutService = workoutService;
            _userManager = userManager;
        }

        /*[HttpPost]
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
        */
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Workout(string name, string data)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            // make sure current user exist
            if (currentUser == null)
            {   // make them login
                return Challenge();
            }
            var workoutExercises = JsonConvert.DeserializeObject<List<WorkoutExercise>>(data);

            var workout = new Workout
            {
                Name = name,
                WorkoutExercises = workoutExercises
            };

            bool success = await _workoutService.AddWorkout(workout, currentUser);

            if (!success)
            {
                return BadRequest("Could not add the exercise");
            }
            ModelState.Clear();
            return await Workout();
            
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Workout()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            // make sure current user exist
            if (currentUser == null)
            {   // make them login
                return Challenge();
            }
            var userExericses = (await _exerciseService.ListExercises(currentUser)).ToList();
            userExericses.AddRange(await _exerciseService.ListDefaultExercises());

            return View(userExericses);
        }
        
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Exercise(Exercise model)
        {
            if (ModelState.IsValid)
            {
                var currentUser = await _userManager.GetUserAsync(User);

                // make sure current user exist
                if (currentUser == null)
                {   // make them login
                    return Challenge();
                }

                bool success = await _exerciseService.AddExercise(model, currentUser);

                if(!success)
                {
                    return BadRequest("Could not add the exercise");
                }
                ModelState.Clear();
                return View();
            }
            // pass in model to redisplay form with users perviously enterered info 
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Exercise()
        {
            return View();
        }
        

    }
}
