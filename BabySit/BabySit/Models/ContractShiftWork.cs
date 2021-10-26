using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class ContractShiftWork
    {
        public int ContractId { get; set; }
        public int BabySitterId { get; set; }
        public DateTime Date { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Night { get; set; }

        public virtual User BabySitter { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
