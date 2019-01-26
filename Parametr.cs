using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Parametr
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int idParametru { get; set; }

        [Required]
        [Display(Name = "Nazwa Parametru:")]
        public string nazwaParametru { get; set; }

        public virtual ICollection<daneSprzetu> daneSprzetu { get; set; }
        public virtual ICollection<Wartosc> Wartosc { get; set; }
    }
}