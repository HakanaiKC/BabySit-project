using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Models
{
    public class Feedback
    {
        private int FeedbackID { get; set; }
        private int BabySitterID { get; set; }
        private int ParenttID { get; set; }
        public string Comment { get; set; }
        public DateTime DateComment { get; set; }
    }
}
