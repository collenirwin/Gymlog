using System.Collections.Generic;

namespace Gymlog.Models.Data
{
    public class Workout
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
