using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models
{
    public class WorkoutExercise
    {
        public string Id { get; set; }
        public string WorkoutId { get; set; }

        public int ExerciseNumber { get; set; }

        [JsonProperty("name")]
        public string ExerciseName { get; set; }

        [NotMapped]
        [JsonProperty("rows")]
        public List<Set> Sets { get; set; }
    }
}
