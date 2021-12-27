using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Login
    {

        [Required]
        [RegularExpression("Username", ErrorMessage = "Enter a Valid Name")]
        public string Username { get; set; }

        [Required]
        [RegularExpression("Password", ErrorMessage = "Enter a Valid Name")]
        public string Password { get; set; }
    }
}
