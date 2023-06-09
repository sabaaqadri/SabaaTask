using System;
using System.Collections.Generic;

#nullable disable

namespace SabaaTask.CORE.Data
{
    public partial class Userlogin
    {
        public decimal Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
        public decimal Roleid { get; set; }
    }
}
