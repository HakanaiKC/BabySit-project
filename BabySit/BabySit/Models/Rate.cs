using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Models
{
    public class Rate
    {
        private int BabySitterID { get; set; }
        private int ParenttID { get; set; }
        private int RateID { get; set; }
        public float rate { get; set; }
    }
}
