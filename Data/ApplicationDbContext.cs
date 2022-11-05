using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KronosVideo.Models;

namespace KronosVideo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KronosVideo.Models.Member> Member { get; set; }
        public DbSet<KronosVideo.Models.Movie> Movie { get; set; }
        public DbSet<KronosVideo.Models.Rental> Rental { get; set; }
    }
}