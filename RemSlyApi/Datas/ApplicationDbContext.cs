using Microsoft.EntityFrameworkCore;
using RemSlyCore.Models;
using RemSlyCore.Datas;

namespace RemSlyApi.Datas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Material> Materials { get; set; }

        public DbSet<Commentary> Commentaries { get; set; }

        //public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().HasData(InitialClub.clubInit);
            //modelBuilder.Entity<Staff>().HasData(InitialStaff.staffs);
        }


    }
}
