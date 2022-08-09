using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class LoginUserVM
    {
        [Required(ErrorMessage = "Email giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre giriniz!")]
        public string Sifre { get; set; }
    }
}