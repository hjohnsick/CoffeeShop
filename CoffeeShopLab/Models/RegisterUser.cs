using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopLab.Models
{
    public class RegisterUser
    {
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 30 characters.")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 30 characters.")]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9{5,30}]+@[a-zA-A0-9{5,10}]+\.[a-zA-Z0-9{2,3}]+$", ErrorMessage ="Please enter a valid email.")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CancelMembership { get; set; }

        public RegisterUser()
        {

        }
        public RegisterUser(string firstName, string lastName, string userName, string email, string password, string cancelMembership)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            CancelMembership = cancelMembership;
        }


    }
}
