using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JanuaryMVC.Models
{
    
    public class Register
    {

        [DisplayName("User Name 123")]
        [Required(ErrorMessage = "Please enter User Name !")]
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$", ErrorMessage = "Username must be 3-20 characters long and can only contain letters, numbers, and underscores.")]
        //[MinLength(10, ErrorMessage = "")]
        //[MaxLength(20, ErrorMessage = "")]
        //[StringLength]
        public string UserName { get; set; }

        [DisplayName("Email ID")]
        [Required(ErrorMessage = "Please enter Email Address !")]
        [EmailAddress(ErrorMessage = "Please enter Proper Email address !")]
        public string Email { get; set; }

        [DisplayName("Age")]
        [Required(ErrorMessage = "Please enter your Age")]
        [Range(18, 35, ErrorMessage = "Please enter valid Age")]
        public int Age { get; set; }

        public int UserId { get; set; }

        public bool IsActive { get; set; }

        public string Gender { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Please enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Confirm password does not matched !")]
        public string ConfirmPassword { get; set; }
    }
}