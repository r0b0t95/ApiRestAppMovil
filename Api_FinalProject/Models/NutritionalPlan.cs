using System;
using System.Collections.Generic;

namespace Api_FinalProject.Models
{
    public partial class NutritionalPlan
    {
        public NutritionalPlan()
        {
            Users = new HashSet<User>();
        }

        public int IdPlan { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string PlanXample { get; set; } = null!;
        public int IdState { get; set; }

        public virtual State IdStateNavigation { get; set; } = null!;
        public virtual ICollection<User> Users { get; set; }
    }
}
