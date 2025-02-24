using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JanuaryMVC.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public List<EmployeeModel> EmployeesList { get; set; }
    }
}