using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class UserVM
    {
        [Required(ErrorMessage = "Ad giriniz!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad giriniz!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "TCKN giriniz!")]
        public string TCKN { get; set; }

        [Required(ErrorMessage = "Email giriniz!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tel No giriniz!")]
        public string TelNo { get; set; }

        [Required(ErrorMessage = "Şifre giriniz!")]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Şifre tekrar giriniz!")]
        [Compare("Sifre", ErrorMessage = "Şifreler aynı değil!")]
        public string SifreTekrar { get; set; }

        
    }
}