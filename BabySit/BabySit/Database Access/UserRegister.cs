using BabySit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class UserRegister
    {
        public User user { get; set; }
        public VerifyCode verifyCode { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }

    }
}

