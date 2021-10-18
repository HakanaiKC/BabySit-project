using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Models
{
    public class User
    {
        [Key]
        private int UserID { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        private string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        private string Password { get; set; }

        private int Role { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        public string Avatar { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enter Birthday")]
        public DateTime BirthOfDate { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Enter Phone")]
        public string Phone { get; set; }

        private int ProvinceID { get; set; }

        [Required(ErrorMessage = "Enter Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Years of Experience")]
        public int YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Enter Your Desired Salary")]
        private float SalaryPerHour { get; set; }

        public int Status { get; set; }

        [Required(ErrorMessage = "Enter Your Account Number")]
        private string AccountNumber { get; set; }

        [Required(ErrorMessage = "Enter Bank name")]
        private string Bank { get; set; }

    }
}
