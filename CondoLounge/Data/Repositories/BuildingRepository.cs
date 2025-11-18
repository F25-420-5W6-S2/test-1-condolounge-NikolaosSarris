using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class BuildingRepository : CondoLoungeGenericGenericRepository<Building>, IBuildingRepository
    {
        public BuildingRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Building>> logger) : base(db, logger)
        {
        }

        public IEnumerable<Building> GetAllUsersForBuilding(int buidlingId)
        {
            throw new NotImplementedException();
        }
    }
}
