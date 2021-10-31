using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BabySit.Models
{
    public class User
    {
        public User()
        {
            ContractBabySitters = new HashSet<Contract>();
            ContractParents = new HashSet<Contract>();
            FeedBackBabySitters = new HashSet<FeedBack>();
            FeedBackParents = new HashSet<FeedBack>();
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

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime? BirthOfDate { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public bool? Gender { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public string Phone { get; set; }
        public int? ProvinceId { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public int? YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Không được bỏ trống trường này")]
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
