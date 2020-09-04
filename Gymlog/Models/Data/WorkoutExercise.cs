using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class WorkoutExercise
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(Workout))]
        public string WorkoutId { get; set; }
        public Workout Workout { get; set; }

        public int ExerciseNumber { get; set; }

        [JsonProperty("name")]
        public string ExerciseName { get; set; }

        [JsonProperty("rows")]
        public virtual ICollection<Set> Sets { get; set; }

        public WorkoutExercise()
        {
            Sets = new HashSet<Set>();
        }
    }
}
