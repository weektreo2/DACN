using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace DACN.Models
{
    public class UserLogin
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Không được bỏ trống!")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Không được bỏ trống")]
        public string Password { get; set; }
        public string GroupID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
    }
}