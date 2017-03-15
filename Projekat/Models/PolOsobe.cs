using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class PolOsobe
    {
        [Key]
        public int PolID { get; set; }
        public string Pol { get; set; }
    }
}