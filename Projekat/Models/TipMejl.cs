using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class TipMejl
    {
        [Key]
        public int TipMejlaID { get; set; }

        
        public string TipMejla { get; set; }
    }
}