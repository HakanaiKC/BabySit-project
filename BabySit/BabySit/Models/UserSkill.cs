using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class UserSkill
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual User User { get; set; }
    }
}
