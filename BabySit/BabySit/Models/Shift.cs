using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Models
{
    public class Shift
    {
        private bool Morning { get; set; }
        private bool Afternoon { get; set; }
        private bool Night { get; set; }
        private int BabySitterID { get; set; }
        private DateTime date { get; set; }
    }
}
