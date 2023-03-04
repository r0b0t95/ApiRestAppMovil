using System;
using System.Collections.Generic;

namespace Api_FinalProject.Models
{
    public partial class ExerciseRoutine
    {
        public ExerciseRoutine()
        {
            Users = new HashSet<User>();
        }

        public int IdRoutine { get; set; }
        public string RoutineName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ExerciseXample { get; set; } = null!;
        public int IdState { get; set; }

        public virtual State IdStateNavigation { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
