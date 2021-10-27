using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class FeedBack
    {
        public int FeedBackId { get; set; }
        public int BabySitterId { get; set; }
        public int ParentId { get; set; }
        public string Comment { get; set; }
        public DateTime DateComment { get; set; }
        public double? Rate { get; set; }

        public virtual User BabySitter { get; set; }
        public virtual User Parent { get; set; }
    }
}
