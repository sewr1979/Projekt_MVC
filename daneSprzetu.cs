using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class daneSprzetu
    {
      

        [Key]
        [Display(Name = "Identyfikator:")]
        public int idDaneSprzetu { get; set; }

        [Required]
        public int IdTyp { get; set; }
        public virtual Typ Typ { get; set; }

        [Required]
        public int IdParametru { get; set; }
        public virtual Parametr Parametr { get; set; }

        public virtual ICollection<Rejestracja> Rejestracja { get; set; }
    }
}