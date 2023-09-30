﻿using System.ComponentModel.DataAnnotations;

namespace TimeZone.ViewModels
{
    public class UserVM
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string Role { get; set; }
        public bool IsDeactive { get; set; }
    }
}
