using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JarvisBuzz.Models
{
    [Table("LoginModel")]
    public class LoginModel
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
    public enum UserRole { 
        User,
        Admin
    };
}