using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Projekat.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<PolOsobe> PoloviOsoba { get; set; }
        public DbSet<Mesto> Mesta { get; set; }
        public DbSet<Opstina> Opstine { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Mejl> Mejlovi { get; set; }
        public DbSet<TipMejl> TipoviMejla { get; set; }
        public DbSet<KontaktTelefon> KontaktTelefoni { get; set; }
        public DbSet<TipKontaktTelefon> TipoviKontaktTelefona { get; set; }
        public DbSet<PttAdresa> PttAdrese { get; set; }
        public DbSet<TipPttAdrese> TipoviPttAdrese { get; set; }
        public DbSet<Stanovanje> Stanovanja { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}