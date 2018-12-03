using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Models
{
    public class LoggedWorkout
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string WorkoutId { get; set; }

        [NotMapped]
        public string[] Notes { get; set; }
        public string NotesString
        {
            get => string.Join("`", Notes);
            set => Notes = value.Split('`');
        }

        [NotMapped]
        public string[] RepsCompleted { get; set; }
        public string RepsCompletedString
        {
            get => string.Join("`", RepsCompleted);
            set => RepsCompleted = value.Split('`');
        }

        [NotMapped]
        public string[] Weight { get; set; }
        public string WeightString
        {
            get => string.Join("`", Weight);
            set => Weight = value.Split('`');
        }

        public DateTime Date { get; set; }
    }
}
