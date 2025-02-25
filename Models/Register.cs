using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JanuaryMVC.Models
{
    public class Register
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public int UserId { get; set; }

        public bool IsActive { get; set; }

        public string Gender { get; set; }

        public string Password { get; set; }
    }
}