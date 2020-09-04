using Gymlog.Models;
using Gymlog.Models.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gymlog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutExercise> WorkoutExercises { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<LoggedWorkout> LoggedWorkouts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Exercise>().HasData(
                new Exercise { Id = "1", UserId = null, ExerciseName = "FLAT BARBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "2", UserId = null, ExerciseName = "FLAT DUMBBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "3", UserId = null, ExerciseName = "INCLINE BARBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "4", UserId = null, ExerciseName = "INCLINE DUMBBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "5", UserId = null, ExerciseName = "DECLINE BARBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "6", UserId = null, ExerciseName = "DECLINE DUMBBELL BENCH PRESS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "7", UserId = null, ExerciseName = "CHEST DIPS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "8", UserId = null, ExerciseName = "PUSH-UPS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "9", UserId = null, ExerciseName = "FLAT DUMBBELL FLYES", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "10", UserId = null, ExerciseName = "INCLINE DUMBBELL FLYES", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "11", UserId = null, ExerciseName = "DECLINE DUMBBELL FLYES", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "12", UserId = null, ExerciseName = "CABLE CROSSOVERS", ExerciseMuscle = "CHEST" },
                new Exercise { Id = "13", UserId = null, ExerciseName = "PULL-UPS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "14", UserId = null, ExerciseName = "CHIN-UPS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "15", UserId = null, ExerciseName = "LAT PULL-DOWNS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "16", UserId = null, ExerciseName = "BENT OVER BARBELL ROWS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "17", UserId = null, ExerciseName = "BENT OVER DUMBBELL ROWS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "18", UserId = null, ExerciseName = "T-BAR ROWS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "19", UserId = null, ExerciseName = "SEATED CABLE ROWS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "20", UserId = null, ExerciseName = "BARBELL SHRUGS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "21", UserId = null, ExerciseName = "DUMBBELL SHRUGS", ExerciseMuscle = "BACK" },
                new Exercise { Id = "22", UserId = null, ExerciseName = "SEATED OVERHEAD BARBELL PRESS", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "23", UserId = null, ExerciseName = "SEATED OVERHEAD DUMBBELL PRESS", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "24", UserId = null, ExerciseName = "STANDING OVERHEAD BARBELL PRESS", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "25", UserId = null, ExerciseName = "STANDING OVERHEAD DUMBBELL PRESS", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "26", UserId = null, ExerciseName = "ARNOLD PRESS", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "27", UserId = null, ExerciseName = "DUMBBELL LATERAL RAISES", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "28", UserId = null, ExerciseName = "DUMBBELL FRONT RAISES", ExerciseMuscle = "SHOULDER" },
                new Exercise { Id = "29", UserId = null, ExerciseName = "SQUAT", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "30", UserId = null, ExerciseName = "FRONT SQUATS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "31", UserId = null, ExerciseName = "BARBELL LUNGES", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "32", UserId = null, ExerciseName = "DUMBBELL LUNGES", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "33", UserId = null, ExerciseName = "LEG PRESS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "34", UserId = null, ExerciseName = "DEADLIFT", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "35", UserId = null, ExerciseName = "STRAIGHT LEG DEADLIFTS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "36", UserId = null, ExerciseName = "SUMO DEADLIFTS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "37", UserId = null, ExerciseName = "HYPEREXTENSIONS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "38", UserId = null, ExerciseName = "GOOD-MORNINGS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "39", UserId = null, ExerciseName = "LEG CURLS", ExerciseMuscle = "LEGS" },
                new Exercise { Id = "40", UserId = null, ExerciseName = "TRICEP DIPS", ExerciseMuscle = "TRICEPS" },
                new Exercise { Id = "41", UserId = null, ExerciseName = "FLAT CLOSE GRIP BENCH PRESS", ExerciseMuscle = "TRICEPS" },
                new Exercise { Id = "42", UserId = null, ExerciseName = "SKULL CRUSHERS", ExerciseMuscle = "TRICEPS" },
                new Exercise { Id = "43", UserId = null, ExerciseName = "DUMBBELL CURLS", ExerciseMuscle = "BICEPS" },
                new Exercise { Id = "44", UserId = null, ExerciseName = "PREACHER CURLS", ExerciseMuscle = "BICEPS" },
                new Exercise { Id = "45", UserId = null, ExerciseName = "HAMMER CURLS", ExerciseMuscle = "BICEPS" });

            builder.Entity<Workout>().HasData(
                new Workout { Id = "1", UserId = null, Name = "StrongLifts 5x5 A" },
                new Workout { Id = "2", UserId = null, Name = "StrongLifts 5x5 B" });

            builder.Entity<WorkoutExercise>().HasData(
                new WorkoutExercise { Id = "1", WorkoutId = "1", ExerciseName = "SQUAT", ExerciseNumber = 1 },
                new WorkoutExercise { Id = "2", WorkoutId = "1", ExerciseName = "FLAT BARBELL BENCH PRESS", ExerciseNumber = 2 },
                new WorkoutExercise { Id = "3", WorkoutId = "1", ExerciseName = "BENT OVER BARBELL ROWS", ExerciseNumber = 3 },
                new WorkoutExercise { Id = "4", WorkoutId = "2", ExerciseName = "SQUAT", ExerciseNumber = 1 },
                new WorkoutExercise { Id = "5", WorkoutId = "2", ExerciseName = "STANDING OVERHEAD BARBELL PRESS", ExerciseNumber = 2 },
                new WorkoutExercise { Id = "6", WorkoutId = "2", ExerciseName = "DEADLIFT", ExerciseNumber = 3 });

            builder.Entity<Set>().HasData(
                new Set { Id = "1", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "1" },
                new Set { Id = "2", SetNumber = 2, Reps = 5, Comments = "", WorkoutExerciseId = "1" },
                new Set { Id = "3", SetNumber = 3, Reps = 5, Comments = "", WorkoutExerciseId = "1" },
                new Set { Id = "4", SetNumber = 4, Reps = 5, Comments = "", WorkoutExerciseId = "1" },
                new Set { Id = "5", SetNumber = 5, Reps = 5, Comments = "", WorkoutExerciseId = "1" },

                new Set { Id = "6", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "2" },
                new Set { Id = "7", SetNumber = 2, Reps = 5, Comments = "", WorkoutExerciseId = "2" },
                new Set { Id = "8", SetNumber = 3, Reps = 5, Comments = "", WorkoutExerciseId = "2" },
                new Set { Id = "9", SetNumber = 4, Reps = 5, Comments = "", WorkoutExerciseId = "2" },
                new Set { Id = "10", SetNumber = 5, Reps = 5, Comments = "", WorkoutExerciseId = "2" },

                new Set { Id = "11", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "3" },
                new Set { Id = "12", SetNumber = 2, Reps = 5, Comments = "", WorkoutExerciseId = "3" },
                new Set { Id = "13", SetNumber = 3, Reps = 5, Comments = "", WorkoutExerciseId = "3" },
                new Set { Id = "14", SetNumber = 4, Reps = 5, Comments = "", WorkoutExerciseId = "3" },
                new Set { Id = "15", SetNumber = 5, Reps = 5, Comments = "", WorkoutExerciseId = "3" },

                new Set { Id = "16", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "4" },
                new Set { Id = "17", SetNumber = 2, Reps = 5, Comments = "", WorkoutExerciseId = "4" },
                new Set { Id = "18", SetNumber = 3, Reps = 5, Comments = "", WorkoutExerciseId = "4" },
                new Set { Id = "19", SetNumber = 4, Reps = 5, Comments = "", WorkoutExerciseId = "4" },
                new Set { Id = "20", SetNumber = 5, Reps = 5, Comments = "", WorkoutExerciseId = "4" },

                new Set { Id = "21", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "5" },
                new Set { Id = "22", SetNumber = 2, Reps = 5, Comments = "", WorkoutExerciseId = "5" },
                new Set { Id = "23", SetNumber = 3, Reps = 5, Comments = "", WorkoutExerciseId = "5" },
                new Set { Id = "24", SetNumber = 4, Reps = 5, Comments = "", WorkoutExerciseId = "5" },
                new Set { Id = "25", SetNumber = 5, Reps = 5, Comments = "", WorkoutExerciseId = "5" },

                new Set { Id = "26", SetNumber = 1, Reps = 5, Comments = "", WorkoutExerciseId = "6" });
        }
    }
}
