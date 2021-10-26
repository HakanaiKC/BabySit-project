using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Contract
    {
        public int ContractId { get; set; }
        public int ParentId { get; set; }
        public int BabySitterId { get; set; }
        public double TotalMoney { get; set; }
        public int NumOfChildren { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }

        public virtual User BabySitter { get; set; }
        public virtual User Parent { get; set; }
    }
}
