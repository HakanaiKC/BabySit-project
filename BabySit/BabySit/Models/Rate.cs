using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Rate
    {
        public int RateId { get; set; }
        public int ParentId { get; set; }
        public int BabySitterId { get; set; }
        public double? Rate1 { get; set; }

        public virtual User BabySitter { get; set; }
        public virtual User Parent { get; set; }
    }
}
