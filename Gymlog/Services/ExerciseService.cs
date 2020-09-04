using Gymlog.Data;
using Gymlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
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
            exercise.ExerciseName = exercise.ExerciseName.ToUpper();
            exercise.ExerciseMuscle = exercise.ExerciseMuscle.ToUpper();

            _context.Exercises.Add(exercise);

            return await SaveAsync();
        }

        private async Task<bool> SaveAsync()
        {
            int result = await _context.SaveChangesAsync(); // pushes to DB
            return result == 1;
        }

        public async Task<Exercise[]> ListExercises(ApplicationUser user)
        {
            return await _context.Exercises
                .Where((exercise) => user.Id == exercise.UserId)
                .ToArrayAsync();
        }

        public async Task<Exercise> GetExercise(string id)
        {
            return await _context.Exercises
                .FirstOrDefaultAsync((exercise) => exercise.Id == id);
        }

        public async Task<bool> UpdateExercise(Exercise exercise)
        {
            var oldExercise = await GetExercise(exercise.Id);
            oldExercise.ExerciseName = exercise.ExerciseName.ToUpper();
            oldExercise.ExerciseMuscle = exercise.ExerciseMuscle.ToUpper();
            return await SaveAsync();
        }

        public async Task<bool> DeleteExercise(Exercise exercise)
        {
            _context.Entry(exercise).State = EntityState.Deleted;
            return await SaveAsync();
        }

        public async Task<Exercise[]> ListDefaultExercises()
        {
            return await _context.Exercises
                .Where((exercise) => null == exercise.UserId)
                .ToArrayAsync();
        }
    }
}
