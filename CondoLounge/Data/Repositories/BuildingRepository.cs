using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class BuildingRepository : CondoLoungeGenericGenericRepository<Building>, IBuildingRepository
    {
        public BuildingRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }

        public IEnumerable<ApplicationUser> GetAllUsersForBuilding(int buildingId)
        {
            return _context.Users
                .Where(u => u.BuildingId == buildingId)
                .ToList();
        }
    }
}
