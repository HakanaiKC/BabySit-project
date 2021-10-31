using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BabySit.Database_Access
{
    public class VerifyCode
    {
        [Required(ErrorMessage = "Không được bỏ trống trường này")]
        public string Email { get; set; }

        public int CodeSend { get; set; }

        [DisplayName("Nhập mã xác nhận ")]
        public int CodeInput { get; set; }


    }
}
