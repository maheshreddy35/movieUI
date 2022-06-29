using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Ratings
    {
        [Required(ErrorMessage = "Please enter Movie")]
        [Display(Name = "Movie")]
        public string movie { get; set; }
        [Required(ErrorMessage = "Please enter Rating")]
        [Display(Name = "Rating")]
        public float rating { get; set; }
        public byte[] Image { get; set; }
    }
}
