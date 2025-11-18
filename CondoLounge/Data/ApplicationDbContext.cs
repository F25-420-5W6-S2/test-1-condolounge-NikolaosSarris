using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CondoLounge.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {        
        public DbSet<ApplicationUser> Users {  get; set; }
        public DbSet<Building> Buildings { get; set; }

        public DbSet<Condo> Condos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasMany(b => b.Buildings)
            //    .WithMany(c => c.Condos)

            //modelBuilder.Entity<Condo>()
            //    .HasOne(c => c.User)
            //    .WithMany(b => b.Buildings)
            //    .HasForeignKey(c => c.UserId);

            //modelBuilder.Entity<Condo>()
            //    .HasOne(c => c.User)
            //    .WithMany()
        }
    }
}
