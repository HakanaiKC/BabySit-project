using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Location
    {
        public Location()
        {
            Users = new HashSet<User>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
