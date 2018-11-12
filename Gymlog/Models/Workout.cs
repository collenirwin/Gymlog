using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Models
{
    public class Workout
    {
        public string UserId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public List<WorkoutExercise> WorkoutExericses { get; set; }
    }
}
