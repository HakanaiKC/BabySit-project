using BabySit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Acess
{
    public class Babysitter
    {
        public IEnumerable<Skill> skills { get; set; }
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Location> locations { get; set; }
        public IEnumerable<UserSkill> userskills { get; set; }
    }
}
