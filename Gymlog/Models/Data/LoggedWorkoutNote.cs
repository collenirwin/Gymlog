using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class LoggedWorkoutNote
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(LoggedWorkout))]
        public string LoggedWorkoutId { get; set; }
        public LoggedWorkout LoggedWorkout { get; set; }
    }
}
