using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projekat.Models
{
    public class TipPttAdrese
    {
        [Key]
        //[Display(Name = "Tip postanske adrese")]
        public int TipaAdreseID { get; set; }

        //[Display(Name = "Tip postanske adrese")]
        public string TipAdrese { get; set; }
    }
}