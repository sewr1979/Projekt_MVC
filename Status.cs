using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Serwis.Models
{
    public class Status
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int idStatus { get; set; }

        [Required]
        [Display(Name = "Nazwa:")]
        public string imie { get; set; }

        public virtual ICollection<Rejestracja> Rejestracja { get; set; }
    }
}