using Gymlog.Data;
using Gymlog.Models;
using Microsoft.EntityFrameworkCore;
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
            exercise.ExerciseName = exercise.ExerciseName.ToUpper();
            exercise.ExerciseMuscle = exercise.ExerciseMuscle.ToUpper();

            _context.Exercises.Add(exercise);

            return await saveAsync();
        }

        private async Task<bool> saveAsync()
        {
            int result = await _context.SaveChangesAsync(); // pushes to DB
            return result == 1;
        }
        public async Task<Exercise[]> ListExercises(ApplicationUser user)
        {
            return await _context.Exercises
                .Where((exercise) =>  user.Id == exercise.UserId)
                .ToArrayAsync();
        }
        public async Task<Exercise> getExercise(string id)
        {
            return await _context.Exercises
                .FirstOrDefaultAsync((exercise) => exercise.Id == id);
        }
        public async Task<bool> updateExercise(Exercise exercise)
        {
            var oldExercise = await getExercise(exercise.Id);
            oldExercise.ExerciseName = exercise.ExerciseName.ToUpper();
            oldExercise.ExerciseMuscle = exercise.ExerciseMuscle.ToUpper();
            return await saveAsync(); 
        }
        public async Task<bool> deleteExercise(Exercise exercise)
        {
            _context.Entry(exercise).State = EntityState.Deleted;
            return await saveAsync();
        }
    }
    
}
