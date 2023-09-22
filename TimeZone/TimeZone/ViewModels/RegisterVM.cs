﻿using System.ComponentModel.DataAnnotations;

namespace TimeZone.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Bosh ola bilmez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bosh ola bilmez!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Bosh ola bilmez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Bosh ola bilmez!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bosh ola bilmez!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bosh ola bilmez!")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string CheckPassword { get; set; }
        public bool IsRemember { get; set; }
    }
}
