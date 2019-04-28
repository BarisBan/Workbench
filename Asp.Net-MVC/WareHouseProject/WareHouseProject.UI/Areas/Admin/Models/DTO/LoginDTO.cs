using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WareHouseProject.UI.Areas.Admin.Models.DTO
{
    public class LoginDTO
    {
        [
           EmailAddress(ErrorMessage = "Enter wrong email"),
           Required(ErrorMessage = "Enter email address"),
       ]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}