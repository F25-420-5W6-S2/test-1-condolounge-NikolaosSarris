using CondoLounge.Data.Entities;
using CondoLounge.Data.Interfaces;

namespace CondoLounge.Data.Repositories
{
    public class CondoRepository : CondoLoungeGenericGenericRepository<Condo>, ICondoRepository
    {
        public CondoRepository(ApplicationDbContext db, ILogger<CondoLoungeGenericGenericRepository<Condo>> logger) : base(db, logger)
        {
        }

        public IEnumerable<Condo> GetAllCondosForBuilding(int buildingId)
        {
            throw new NotImplementedException();
        }
    }
}
