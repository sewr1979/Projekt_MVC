using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Typ
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int idTyp { get; set; }

        [Required]
        [Display(Name = "Typ urządzenia:")]
        public string nazwaTyp { get; set; }

        public virtual ICollection<daneSprzetu> daneSprzetu { get; set; }
        public virtual ICollection<Sprzet> Sprzet { get; set; }
    }
}