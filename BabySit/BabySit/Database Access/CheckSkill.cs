using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class CheckSkill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public bool CheckSkillId { get; set; }

        public CheckSkill(int skillId, string skillName, bool checkSkillId)
        {
            SkillId = skillId;
            SkillName = skillName;
            CheckSkillId = checkSkillId;
        }
    }
}
