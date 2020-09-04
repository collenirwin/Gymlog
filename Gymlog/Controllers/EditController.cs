using Gymlog.Models;
using Gymlog.Models.Data;
using Gymlog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            var exercise = await _exerciseService.GetExercise(id);

            if (exercise.UserId == currentUser.Id)
            {
                return View(exercise);
            }

            return Challenge();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Exercise(Exercise exercise)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (exercise.UserId == currentUser.Id)
            {
                await _exerciseService.UpdateExercise(exercise);
                return RedirectToAction("Exercises", "Saved");
            }

            return Challenge();
        }
    }
}
