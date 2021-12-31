using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PMS_Repository.Dtos
{
    public partial class Patient
    {
        public int PId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required,MinLength(2,ErrorMessage ="Please don't use abbreviations")]
        public string FirstName { get; set; }
        [Required,MinLength(2,ErrorMessage = "Please don't use abbreviations")]
        public string LastName { get; set; }

        [Required,EmailAddress]
        public string EmailId { get; set; }
       
        public DateTime? Dob { get; set; }
        public string Role { get; set; }
        public int? Count { get; set; }
        [Required,MinLength(8,ErrorMessage ="Password is weak. Please re-enter the password with a minimum of one Uppercase letter, one lowercase letter, one number and minimum length of 8 characters")]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
