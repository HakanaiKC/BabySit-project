using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BabySit.Models
{
    public partial class User
    {
        public User()
        {
            FeedBackBabySitters = new HashSet<FeedBack>();
            FeedBackParents = new HashSet<FeedBack>();
            Payments = new HashSet<Payment>();
            Shifts = new HashSet<Shift>();
        }

        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Mật khẩu")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Độ dài mật khẩu phải từ 8 - 32 chữ cái")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Role { get; set; }
        public DateTime RegisterDate { get; set; }

        public string Avatar { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
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
        public virtual ICollection<FeedBack> FeedBackBabySitters { get; set; }
        public virtual ICollection<FeedBack> FeedBackParents { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}
