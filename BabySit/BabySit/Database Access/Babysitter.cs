using BabySit.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class Babysitter
    {
        public IEnumerable<Skill> skills { get; set; }
        public IEnumerable<User> users { get; set; }
        public IEnumerable<Location> locations { get; set; }
        public IEnumerable<UserSkill> userskills { get; set; }
        public IFormFile Avatar { get; set; }
        public IEnumerable<Shift> shift { get; set; }
        public IEnumerable<Payment> payment { get; set; }
        public IEnumerable<FeedBack> feedBacks { get; set; }
        public IEnumerable<Favorite> favorites { get; set; }
    }
}
