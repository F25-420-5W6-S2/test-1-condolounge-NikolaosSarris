using CondoLounge.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data
{
    public class CondoLoungeSeeder
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public CondoLoungeSeeder(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<int>> roleManager)
        {
            _db = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            // Seed Roles
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole<int>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<int>("Default"));
            }

            // Seed Initial Building
            if (!_db.Buildings.Any())
            {
                var initialBuilding = new Building
                {
                    BuildingName = "John Abbott"
                };
                _db.Buildings.Add(initialBuilding);
                _db.SaveChanges();
            }

            // Seed inital Condo
            if (!_db.Condos.Any())
            {
                var initialCondo = new Condo
                {
                    CondoNumber = 1,
                };

                _db.Condos.Add(initialCondo);
                _db.SaveChanges();
            }

            // Seed Admin User
            if (!_userManager.Users.Any())
            {
                var adminUser = new ApplicationUser
                {
                    UserName = "admin@fishtrack.com",
                    Email = "admin@fishtrack.com",
                };

                await _userManager.CreateAsync(adminUser, "Admin@123");
                await _userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
