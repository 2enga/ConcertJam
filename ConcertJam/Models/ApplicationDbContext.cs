using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ConcertJam.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Show> Shows { get; set; }
        public DbSet<Genre> Genres { get; set; }
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