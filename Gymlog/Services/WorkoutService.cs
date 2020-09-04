using Gymlog.Data;
using Gymlog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Services
{
    public class WorkoutService
    {
        private readonly ApplicationDbContext _context;

        public WorkoutService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddWorkout(Workout workout, ApplicationUser user)
        {
            int postCount = 0;
            workout.Id = Guid.NewGuid().ToString();
            workout.UserId = user.Id;
            _context.Workouts.Add(workout);
            postCount++;
            int count = 1;

            foreach (var workoutExercise in workout.WorkoutExercises)
            {
                workoutExercise.ExerciseNumber = count++;
                workoutExercise.Id = Guid.NewGuid().ToString();
                workoutExercise.WorkoutId = workout.Id;
                _context.WorkoutExercises.Add(workoutExercise);
                postCount++;
                foreach (var set in workoutExercise.Sets)
                {
                    set.Id = Guid.NewGuid().ToString();
                    set.WorkoutExerciseId = workoutExercise.Id;
                    _context.Sets.Add(set);
                    postCount++;
                }
            }

            return await SaveAsync(postCount);
        }

        private async Task<bool> SaveAsync(int expected)
        {
            int result = await _context.SaveChangesAsync(); // pushes to DB
            return result == expected;
        }

        public async Task<Workout[]> ListWorkouts(ApplicationUser user)
        {
            return await _context.Workouts
                .Where((workout) => user.Id == workout.UserId)
                .ToArrayAsync();
        }

        public async Task<Workout> GetWorkout(string id)
        {
            var workout = await _context.Workouts
                .FirstOrDefaultAsync((w) => w.Id == id);

            workout.WorkoutExercises = await _context.WorkoutExercises
                .Where((w) => w.WorkoutId == workout.Id).OrderBy((x) => x.ExerciseNumber).ToListAsync();

            foreach (var workoutExercise in workout.WorkoutExercises)
            {
                workoutExercise.Sets = await _context.Sets
                    .Where((s) => s.WorkoutExerciseId == workoutExercise.Id).OrderBy((x) => x.SetNumber).ToListAsync();
            }

            return workout;
        }

        public async Task<bool> LogWorkout(ApplicationUser user, LoggedWorkout model)
        {
            model.Id = Guid.NewGuid().ToString();
            model.UserId = user.Id;
            model.Date = DateTime.Now;
            _context.LoggedWorkouts.Add(model);
            return await SaveAsync(1);
        }

        public async Task<LoggedWorkout[]> ListLoggedWorkouts(ApplicationUser user)
        {
            return await _context.LoggedWorkouts
                .Where((workout) => user.Id == workout.UserId)
                .OrderByDescending((workout) => workout.Date)
                .ToArrayAsync();
        }

        public async Task<LoggedWorkout> GetLoggedWorkout(string id)
        {
            var workout = await _context.LoggedWorkouts
                .FirstOrDefaultAsync((w) => w.Id == id);
            return workout;
        }

        public async Task<Workout[]> ListDefaultWorkouts(ApplicationUser user)
        {
            return await _context.Workouts
                .Where((workout) => null == workout.UserId)
                .ToArrayAsync();
        }
    }
}
