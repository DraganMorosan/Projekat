using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekat.Models
{
    public class Stanovanje
    {
        [Key]
        [Column(Order = 1)]
        public int OsobaID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int AdresaID { get; set; }
    }
}