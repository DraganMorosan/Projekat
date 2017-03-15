using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class Osoba
    {
        [Key]
        public int OsobaID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        [Display (Name = "Ime jednog roditelja")]
        public string ImeRoditelja { get; set; }

        [Display(Name = "Vas JMBG")]
        public int JMBG { get; set; }

        [Display(Name = "Datum rodjenja")]
        public DateTime DatumRodjenja { get; set; }


        public Mesto Mesto { get; set; }
        public Opstina Opstina { get; set; }
        public PolOsobe PolOsobe { get; set; }

        [Display(Name = "Broj licne karte")]
        public int BrojLicneKarte { get; set; }
        public KontaktTelefon KontaktTelefon { get; set; }
        public Mejl Mejl { get; set; }
        public PttAdresa PttAdresa { get; set; }

        public int AdresaID { get; set; }
        public int MejlID { get; set; }
        public int KontaktTelefonID { get; set; }
        public int OpstinaID { get; set; }
        public int PolID { get; set; }
        public int MestoID { get; set; }
    }
}