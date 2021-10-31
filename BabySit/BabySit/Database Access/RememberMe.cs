using BabySit.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class RememberMe
    {
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [EmailAddress]
        public string Email { get; set; }
  
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        [DisplayName("Mật khẩu")]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "Độ dài mật khẩu phải từ 8 - 32 chữ cái")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }

}
