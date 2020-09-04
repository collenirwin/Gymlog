using System.ComponentModel.DataAnnotations;

namespace Gymlog.Models.Data
{
    public class Exercise
    {
        [Required]
        [Display(Name = "Name")]
        public string ExerciseName { get; set; }

        [Required]
        [Display(Name = "Muscle Group")]
        public string ExerciseMuscle { get; set; }

        [Key]
        public string Id { get; set; }

        //forign key
        public string UserId { get; set; }
    }
}
