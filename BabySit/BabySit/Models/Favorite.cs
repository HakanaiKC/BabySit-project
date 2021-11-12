using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int ParentsId { get; set; }
        public int BabysitterId { get; set; }

        public virtual User Babysitter { get; set; }
        public virtual User Parents { get; set; }
    }
}
