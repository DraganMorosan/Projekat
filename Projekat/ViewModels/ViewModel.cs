using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekat.Models;
using System.ComponentModel.DataAnnotations;

namespace Projekat.ViewModels
{
    public class ViewModel
    {
        public Osoba Osoba { get; set; }
        public Grad Grad { get; set; }
        public KontaktTelefon KontaktTelefon { get; set; }
        public Mejl Mejl { get; set; }
        public Mesto Mesto { get; set; }
        public Opstina Opstina { get; set; }
        public PolOsobe PolOsobe { get; set; }
        public PttAdresa PttAdresa { get; set; }

        [Display(Name = "Tip broja telefona")]
        public TipKontaktTelefon TipKontaktTelefon { get; set; }

        [Display(Name = "Tip E-mail adrese")]
        public TipMejl TipMejl { get; set; }

        [Display(Name = "Tip postanske adrese")]
        public TipPttAdrese TipPttAdrese { get; set; }
        public Stanovanje Stanovanje { get; set; }

        public IEnumerable<PolOsobe> PoloviOsobe { get; set; }
        public IEnumerable<TipKontaktTelefon> TipoviKontaktTelefon { get; set; }
        public IEnumerable<TipMejl> TipoviMejla { get; set; }
        public IEnumerable<TipPttAdrese> TipoviAdresa { get; set; }
    }
}