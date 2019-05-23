using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Models
{
    public class Register
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = " wrong mail address")]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }       
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Passwords are not same")]
        public string RePassword { get; set; }
    }
}