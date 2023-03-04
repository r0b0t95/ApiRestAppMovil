using System;
using System.Collections.Generic;

namespace Api_FinalProject.Models
{
    public partial class State
    {
        public State()
        {
            ExerciseRoutines = new HashSet<ExerciseRoutine>();
            NutritionalPlans = new HashSet<NutritionalPlan>();
            Users = new HashSet<User>();
        }

        public int IdState { get; set; }
        public string StateName { get; set; } = null!;
        public string? Detail { get; set; }

        public virtual ICollection<ExerciseRoutine> ExerciseRoutines { get; set; }
        public virtual ICollection<NutritionalPlan> NutritionalPlans { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
