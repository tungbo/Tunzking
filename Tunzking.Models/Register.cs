using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tunzking.Utility;

namespace Tunzking.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name can't be blank")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Name can't be blank")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be in a poper email address format")]
        [Remote(action: "IsEmailAlreadyRegistered", controller: "Account", ErrorMessage = "Email is already in use")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number can't be blank")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Phone number ?")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Address can't be blank")]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "City can't be blank")]
        public string City { get; set; }
        [Required(ErrorMessage = "Password can't be blank")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public UserTypeOptions UserType { get; set; } = UserTypeOptions.User;
    }
}
