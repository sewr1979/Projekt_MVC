using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Serwis.Models
{
    public class Uzytkownik : IdentityUser
    {
        
     

        [Key]
        [Display(Name = "Identyfikator:")]
        public int idUzytkownik { get; set; }

        [Required]
        [Display(Name = "Imię:")]
        public string imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko:")]
        public string nazwisko { get; set; }

        [Required]
        [Display(Name = "Numer Klienta:")]
        public string nrKlienta { get; set; }

        [Required]
        [Display(Name = "Numer Pracownika:")]
        public string nrPracownika { get; set; }

        [Required]
        [Display(Name = "Miejscowość:")]
        public string miejscowosc { get; set; }

        [Required]
        [Display(Name = "Kod pocztowy:")]
        public string kodPocztowy { get; set; }

        [Required]
        [Display(Name = "Ulica:")]
        public string ulica { get; set; }

        [Required]
        [Display(Name = "Telefon:")]
        public string nrTelefonu { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Uzytkownik> manager)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }

    }
}