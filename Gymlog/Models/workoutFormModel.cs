using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymlog.Models
{
    public class WorkoutFormModel
    {
        public int Id { get; set; }
        public string Rows { get; set; }
        public string Exercise { get; set; }
        public int Set { get; set; }
        public int Reps { get; set; }
        public string Rest_time { get; set; }
        public string Comments { get; set; }
        public string Date { get; set; }
    }
}
