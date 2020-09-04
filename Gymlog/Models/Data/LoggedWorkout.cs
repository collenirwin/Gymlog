using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class LoggedWorkout
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey(nameof(Workout))]
        public string WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public string WorkoutName { get; set; }

        [InverseProperty(nameof(LoggedWorkoutNote.LoggedWorkout))]
        public virtual ICollection<LoggedWorkoutNote> Notes { get; set; }

        [InverseProperty(nameof(LoggedWorkoutSet.LoggedWorkout))]
        public virtual ICollection<LoggedWorkoutSet> Sets { get; set; }

        public DateTime Date { get; set; }

        public LoggedWorkout()
        {
            Notes = new HashSet<LoggedWorkoutNote>();
            Sets = new HashSet<LoggedWorkoutSet>();
        }
    }
}
