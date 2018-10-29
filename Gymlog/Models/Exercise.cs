using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Models
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
