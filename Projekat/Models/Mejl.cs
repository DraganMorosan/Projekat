using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Mejl
    {
        [Key]
        public int MejlID { get; set; }

        [Display(Name = "E-mail")]
        public string NazivMejla { get; set; }
        public int TipMejlaID { get; set; }
        public int OsobaID { get; set; }
    }
}