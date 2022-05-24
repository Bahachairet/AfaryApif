using AfaryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AfaryApi.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<Gig> Gigs { get; set; }
    }
}
