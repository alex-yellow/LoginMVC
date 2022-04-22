using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginMVC.Models
{
    public class Account
    {
        [Display(Name = "Имя")]
        public string Username { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}