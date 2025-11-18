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

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(b => b.Building)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.BuildingId);

            modelBuilder.Entity<Condo>()
                .HasOne(u => u.User)
                .WithMany(c => c.Condos)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<Condo>()
                .HasOne(b => b.Building)
                .WithMany(c => c.Condos)
                .HasForeignKey(u => u.BuildingId);
        }
    }
}
