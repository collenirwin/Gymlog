using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class LoggedWorkoutSet
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(LoggedWorkout))]
        public string LoggedWorkoutId { get; set; }
        public LoggedWorkout LoggedWorkout { get; set; }

        [ForeignKey(nameof(Set))]
        public string SetId { get; set; }
        public Set Set { get; set; }

        public int RepsCompleted { get; set; }
        public string Weight { get; set; }
    }
}
