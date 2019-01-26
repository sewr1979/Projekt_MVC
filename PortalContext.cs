using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Serwis.Models;

namespace Biblioteka.Models
{
    // Możesz dodać dane profilu dla użytkownika, dodając więcej właściwości do klasy Uzytkownik. Odwiedź stronę https://go.microsoft.com/fwlink/?LinkID=317594, aby dowiedzieć się więcej.


    public class PortalContext : IdentityDbContext
    {
        public PortalContext()
            : base("PortalConnection")
        {
        }

        public static PortalContext Create()
        {
            return new PortalContext();
        }

        public DbSet<daneSprzetu> daneSprzetu { get; set; }
        public DbSet<Sprzet> Sprzet { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Uzytkownik> Uzytkownik { get; set; }
        public DbSet<Wartosc> Wartosc { get; set; }
        public DbSet<Typ> Typ { get; set; }
        public DbSet<Rejestracja> Rejestracja { get; set; }
        public DbSet<Parametr> Parametr { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

}