﻿using System.ComponentModel.DataAnnotations.Schema;

namespace libraryWeb.Models
{
    [Table("register")]
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
