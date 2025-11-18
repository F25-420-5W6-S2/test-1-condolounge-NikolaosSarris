using CondoLounge.Data.Entities;

namespace CondoLounge.Data.Interfaces
{
    public interface ICondoRepository : ICondoLoungeGenericRepository<Condo>
    {
        IEnumerable<Condo> GetAllCondosForBuilding(int buildingId);
    }
}
