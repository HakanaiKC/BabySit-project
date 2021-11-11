using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public int? TradingCode { get; set; }
        public int? Phone { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public bool? Status { get; set; }

        public virtual User User { get; set; }
    }
}
