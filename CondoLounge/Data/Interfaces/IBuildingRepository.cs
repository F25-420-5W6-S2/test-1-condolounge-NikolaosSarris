using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface IBuildingRepository : ICondoLoungeGenericRepository<Building>
    {
        IEnumerable<Building> GetAllUsersForBuilding(int buidlingId);
    }
}
