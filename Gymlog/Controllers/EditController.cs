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
    public class EditController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ExerciseService _exerciseService;

        public EditController(ExerciseService exerciseService, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _exerciseService = exerciseService;
        } 

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Exercise(string id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var exercise = await _exerciseService.getExercise(id);

            if (exercise.UserId == currentUser.Id)
            {
                return View(exercise);
            }
            else
            {
                return Challenge();
            }
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Exercise(Exercise exercise)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (exercise.UserId == currentUser.Id)
            {
                await _exerciseService.updateExercise(exercise);
                return RedirectToAction("Exercises","Saved");
            }
            else
            {
                return Challenge();
            }
        }
    }
}