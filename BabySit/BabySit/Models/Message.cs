using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Message
    {
        public int SenderId { get; set; }
        public string Message1 { get; set; }
        public int ReceiverId { get; set; }
        public TimeSpan? TimeChat { get; set; }

        public virtual User Sender { get; set; }
    }
}
