﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class UserRegister
    {
        [Required(ErrorMessage = "the name field is empty")]
        [Display(Name = "Username")]
        [RegularExpression(@"^[A-Za -z]+", ErrorMessage = "the username field is not a valid name")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Name must be more than 4 characters and less than 30 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The Email field is empty")]
        [EmailAddress(ErrorMessage = "The Emai Address field is not a valid e-mail address")]
        [Display(Name = "Email Address")]
        [StringLength(30, ErrorMessage = "Email must be less then 30 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "the password field is empty")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "password must be more than 5 characters")]
        public string Password { get; set; }
    }
}