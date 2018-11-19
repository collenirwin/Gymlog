using System;
using System.Collections.Generic;
using System.Text;
using Gymlog.Models;
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


        }

    }
}
