﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAVINAFILMS.ViewModel
{
    public class LoginViewModel
    {

        [Required]
        [Display(Name = "Логін")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}


