using Newtonsoft.Json;

namespace Gymlog.Models.Data
{
    public class Set
    {
        public string Id { get; set; }
        public string WorkoutExerciseId { get; set; }

        [JsonProperty("setNumber")]
        public int SetNumber { get; set; }

        [JsonProperty("reps")]
        public int Reps { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }
}
