using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymlog.Models;
using Gymlog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    public class SavedController : Controller
    {
        private readonly ExerciseService _exerciseService;
        private readonly UserManager<ApplicationUser> _userManager;

        public SavedController(ExerciseService exerciseService, UserManager<ApplicationUser> userManager)
        {
            _exerciseService = exerciseService;
            _userManager = userManager;
        }

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
        [Authorize]
        public async Task<IActionResult> Exercises()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            var exercises = await _exerciseService.ListExercises(currentUser);
            return View(exercises);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteExercise(string exericseId)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var exercise = await _exerciseService.getExercise(exericseId);

            if (exercise.UserId == currentUser.Id)
            {
                await _exerciseService.deleteExercise(exercise);
                return RedirectToAction("Exercises");
            }
            else
            {
                return Challenge();
            }
        }
    }
}