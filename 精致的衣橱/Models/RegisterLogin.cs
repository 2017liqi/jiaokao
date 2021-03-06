﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace 精致的衣橱.Models
{
    public class RegisterLogin
    {
        public int UserID { get; set; }

        [Required]
        [Display(Name = "姓名")]
        public string TrueName { get; set; }

        [Required]
        [Display(Name = "密码")]
        public string PasswordL { get; set; }


        [Required]
        [Display(Name = "密码")]
        [StringLength(20, MinimumLength = 6)]
        public string PasswordR { get; set; }


        [Required]
        [Display(Name = "确认密码")]
        [Compare("PasswordR")]
        public string ConfirmPassword { get; set; }

        //[Required]
        //[Display(Name = "邮箱")]
        //[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9._]+\.[A-Za-z]{2,4}")]
        //public string Email { get; set; }
        [Required]
        [Display(Name ="电话")]
        [StringLength(11)]
        public string Tel{ get; set; }

        [Display(Name = "记住我")]
        public bool Rememberme { get; set; }

        [Display(Name = "验证码")]
        public string YZM { get; set; }
    }
}