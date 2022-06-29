using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MVCMovie.Models
{
    public class Bank
    {
        [Required(ErrorMessage = "Please enter Account Number")]
        [Display(Name = "Account Number")]
        public string AccNo { get; set; }
        [Required(ErrorMessage = "Please enter Your name")]
        [Display(Name = "Account Holder name")]
        public string AccHolderName { get; set; }
        [Required(ErrorMessage = "Please enter Account Type")]
        [Display(Name = "Account Type")]
        public string AccType { get; set; }
        [Required(ErrorMessage = "Please enter Date")]
        [Display(Name = "Date of Creation")]
        public DateTime? Doj { get; set; }
        [Required(ErrorMessage = "Please enter Balance")]
        [Display(Name = "Balance")]
        public double? Balance { get; set; }
        [Required(ErrorMessage = "Please Password")]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Please enter strong password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        public string phno { get; set; }
        
    }
}
