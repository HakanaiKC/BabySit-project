using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Models
{
    public class Contract
    {
        private int ContractID { get; set; }
        private int ParentID { get; set; }
        private int BabySitterID { get; set; }
        private float TotalMoney { get; set; }
        private int NumOfChildren { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private int Status { get; set; }
    }
}
