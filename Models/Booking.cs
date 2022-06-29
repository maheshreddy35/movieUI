using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Movie Namr")]
        [Display(Name = "Movie Name")]
        public string Movie { get; set; }
        [Required(ErrorMessage = "Please enter Theater name")]
        [Display(Name = "Theater Name")]
        public string Theater { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter Price")]
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Please enter Time")]
        [Display(Name = "Time")]
        public DateTime? Time { get; set; }
        [Required(ErrorMessage = "Please enter Mobile Number")]
        [Display(Name = "Mobile Number")]
        public string Phno { get; set; }
        [Required(ErrorMessage = "Please enter Number of Tickets")]
        [Display(Name = "No.of Tickets")]
        
        public string NoOfTickets { get; set; }
        public byte[] Image { get; set; }
    }
}
