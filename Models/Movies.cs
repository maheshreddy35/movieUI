using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Movies
    {
        [Required(ErrorMessage = "Please enter Id")]
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please EnterTheater Name")]
        [Display(Name = "Theater")]
        public string Theatername { get; set; }
        [Required(ErrorMessage = "Please Enter Movie")]
        [Display(Name = "Movie")]
        public string Movie { get; set; }
        [Required(ErrorMessage = "Please enter Price")]
        [Display(Name = "Price")]
        public double? Price { get; set; }
        public byte[] Image { get; set; }
    }
}
