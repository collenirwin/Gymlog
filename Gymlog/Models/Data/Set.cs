using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class Set
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(Workout))]
        public string WorkoutId { get; set; }
        public Workout Workout { get; set; }

        [JsonProperty("setNumber")]
        public int SetNumber { get; set; }

        [JsonProperty("reps")]
        public int Reps { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}
