namespace CondoLounge.Data.Entities
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string BuildingName { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
        public ICollection<Condo> Condos { get; set; }
    }
}
