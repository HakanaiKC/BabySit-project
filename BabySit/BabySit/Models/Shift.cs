using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Shift
    {
        public int BabySitterId { get; set; }
        public int Date { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Night { get; set; }

        public virtual User BabySitter { get; set; }
    }
}
