using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Grad
    {
        [Key]
        public int GradID { get; set; }

        [Display(Name = "Grad")]
        public string NazivGrada { get; set; }
        public int OpstinaID { get; set; }
    }
}