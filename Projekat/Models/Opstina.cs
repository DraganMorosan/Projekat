using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Opstina
    {
        [Key]
        public int OpstinaID { get; set; }

        [Display(Name = "Opstina rodjenja")]
        public string NazivOpstine { get; set; }
    }
}