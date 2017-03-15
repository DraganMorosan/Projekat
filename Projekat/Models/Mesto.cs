using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Mesto
    {
        [Key]
        public int MestoID { get; set; }

        [Display(Name = "Mesto rodjenja")]
        public string NazivMesta { get; set; }
        public int OpstinaID { get; set; }
    }
}