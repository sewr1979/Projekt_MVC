using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Rejestracja
    {
       

        [Key]
        [Display(Name = "Identyfikator:")]
        public int idRejestracja { get; set; }

        [Required]
        [Display(Name = "Opis:")]
        public string Opis { get; set; }

        public string Klient_ID { get; set; }
        public string Pracownik_ID { get; set; }

        [ForeignKey("Klient_ID")]
        public virtual Uzytkownik Klient { get; set; }

        [ForeignKey("Pracownik_ID")]
        public virtual Uzytkownik Pracownik { get; set; }

        [Required]
        public int idDaneSprzetu { get; set; }
        public virtual daneSprzetu DaneSprzetu { get; set; }

        [Required]
        public int idStatus { get; set; }
        public virtual Status Status { get; set; }







    }
}