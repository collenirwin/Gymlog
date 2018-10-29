using Gymlog.Data;
using Gymlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Services
{
    public class ExerciseService
    {
        private readonly ApplicationDbContext _context;

        public ExerciseService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddExercise(Exercise exercise, ApplicationUser user)
        {
            exercise.Id = Guid.NewGuid().ToString();
            exercise.UserId = user.Id;

            _context.Exercises.Add(exercise);

            return await saveAsync();
        }

        private async Task<bool> saveAsync()
        {
            int result = await _context.SaveChangesAsync(); // pushes to DB
            return result == 1;
        }
    }
}
