namespace CondoLounge.Data.Entities
{
    public class Condo
    {
        public int CondoId { get; set; }
        public int CondoNumber { get; set; }
        public string Location { get; set; }

        public int UserId { get; set; }
        public int BuildingId { get; set; }

        public ApplicationUser User { get; set; }
        public Building Building { get; set; }
    }
}
