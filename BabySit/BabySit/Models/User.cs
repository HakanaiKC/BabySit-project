using System;
using System.Collections.Generic;

#nullable disable

namespace BabySit.Models
{
    public partial class User
    {
        public User()
        {
            ContractBabySitters = new HashSet<Contract>();
            ContractParents = new HashSet<Contract>();
            FeedBackBabySitters = new HashSet<FeedBack>();
            FeedBackParents = new HashSet<FeedBack>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public DateTime? BirthOfDate { get; set; }
        public bool? Gender { get; set; }
        public string Phone { get; set; }
        public int? ProvinceId { get; set; }
        public string Description { get; set; }
        public int? YearsOfExperience { get; set; }
        public double? SalaryPerHour { get; set; }
        public int? Status { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }

        public virtual Location Province { get; set; }
        public virtual ICollection<Contract> ContractBabySitters { get; set; }
        public virtual ICollection<Contract> ContractParents { get; set; }
        public virtual ICollection<FeedBack> FeedBackBabySitters { get; set; }
        public virtual ICollection<FeedBack> FeedBackParents { get; set; }
    }
}
