using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EspacoX_V3.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(255)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; } = "User";


        public void Register()
        {
        }
        public void UpdateProfile()
        {
        }
    }
}