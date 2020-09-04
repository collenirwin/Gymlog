using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gymlog.Models.Data
{
    public class Exercise
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ExerciseName { get; set; }

        [Required]
        [Display(Name = "Muscle Group")]
        public string ExerciseMuscle { get; set; }
    }
}
