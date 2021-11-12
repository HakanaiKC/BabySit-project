using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public string TradingCode { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public bool? Status { get; set; }
        public decimal? Money { get; set; }

        public virtual User User { get; set; }
    }
}
