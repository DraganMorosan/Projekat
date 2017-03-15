using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Projekat.Models
{
    public class TipKontaktTelefon
    {
        [Key]
        public int TipKontaktTelefonID { get; set; }

        
        public string TipKontaktTelefona { get; set; }
    }
}