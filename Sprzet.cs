using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Sprzet
    {

        

        [Key]
        [Display(Name = "Identyfikator:")]
        public int idSprzet { get; set; }

        [Required]
        [Display(Name = "Numer Seryjny:")]
        public string nrSeryjny { get; set; }

        [Required]
        public int idTyp { get; set; }
        public virtual Typ Typ { get; set; }


        public virtual ICollection<Wartosc> Wartosc { get; set; }
    


    }
}