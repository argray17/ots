using Microsoft.EntityFrameworkCore;
using ots.Models;

namespace ots.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
