using Microsoft.EntityFrameworkCore;
using Portfolio_API.Models;

namespace Portfolio_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<Types_Experiences> Types_Experiences { get; set; }
    }
}
