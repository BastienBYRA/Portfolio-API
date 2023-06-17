using Microsoft.EntityFrameworkCore;
using Portfolio_API.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        public DbSet<Category_Language> Category_Languages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*            modelBuilder.Entity<Langage>()
            .HasOne<Project>(sc => sc.Pro)
            .WithMany(s => s.StudentCourses)
            .HasForeignKey(sc => sc.SId);*/
        }
    }


}
