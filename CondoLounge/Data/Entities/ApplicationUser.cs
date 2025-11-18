using Microsoft.AspNetCore.Identity;

namespace CondoLounge.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public ICollection<Condo> Condos { get; set; }
    }
}
