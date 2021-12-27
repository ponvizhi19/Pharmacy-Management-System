using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Models
{
    public partial class Admin
    {
        public decimal Id { get; set; }
        public string UserRole { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
