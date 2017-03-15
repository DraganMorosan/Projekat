using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class KontaktTelefon
    {
        [Key]
        public int KontaktTelefonID { get; set; }

        [Display(Name = "Broj telefona")]
        public int BrojTelefona { get; set; }

        [Display(Name = "Lokal")]
        public string Lokal { get; set; }

        public int SifraTipaKontaktTelefon { get; set; }
        public int OsobaID { get; set; }
    }
}