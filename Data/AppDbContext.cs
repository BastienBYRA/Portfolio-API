using Microsoft.EntityFrameworkCore;
using Portfolio_API.Models;

namespace Portfolio_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<Type_Experience> Types_Experiences { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Langage> Langages { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
