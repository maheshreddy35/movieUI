using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace MVCMovie.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        [MinLength(10)]
        public string Phoneno { get; set; }
        [Required(ErrorMessage = "Please enter full name")]
        [Display(Name = "Full Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter valid age")]
        [Display(Name = "Age")]
        [Range(0,200,ErrorMessage="Please enter valid age")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Please Password")]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$",ErrorMessage="Please enter strong password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
