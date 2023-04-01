﻿using System.ComponentModel.DataAnnotations;

namespace JWTToken.Models
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string? DisplayName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
