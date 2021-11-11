using BabySit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class Search
    {
        public IEnumerable<Skill> skills { get; set; }
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Location> locations { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public IEnumerable<UserSkill> userskills { get; set; }
        
    }
}
