using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Wartosc
    {
        
        [Key]
        [Display(Name = "Identyfikator:")]
        public int idWartosc { get; set; }

        [Required]
        [Display(Name = "Wartość:")]
        public string wartosc { get; set; }

        [Required]
        public int IdParametru { get; set; }
        public virtual Parametr Parametr { get; set; }

        [Required]
        public int IdSprzet { get; set; }
        public virtual Sprzet Sprzet { get; set; }
    }
}