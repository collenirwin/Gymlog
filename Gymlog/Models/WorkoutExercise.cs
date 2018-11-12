using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Models
{
    public class WorkoutExercise
    {
        public string Id { get; set; }
        public string WorkoutId { get; set; }

        [JsonProperty("name")]
        public string ExerciseName { get; set; }

        [NotMapped]
        [JsonProperty("rows")]
        public List<Set> Sets { get; set; }
    }
}
