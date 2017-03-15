using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class PttAdresa
    {
        [Key]
        public int AdresaID { get; set; }

        [Display(Name = "Postanska adresa")]
        public string NazivPttAdresa { get; set; }

        [Display(Name = "Postanski broj")]
        public int PostanskiBroj { get; set; }
        //[Display(Name = "Tip postanske adrese")]
        public int TipAdreseID { get; set; }
        public int GradID { get; set; }
    }
}