using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class Workout
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<WorkoutExercise> WorkoutExercises { get; set; }
    }
}
