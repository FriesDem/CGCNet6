using System.ComponentModel.DataAnnotations.Schema;

namespace CouncilGamingClub.web.Data
{
    public class Inventory
    {
        public int Id { get; set; }

        public string ProductName { get; set; }
        public int Price { get; set; }

        [ForeignKey("SuppliersProductID")]
        public Suppliers Suppliers { get; set; }
        public int SuppliersProductID { get; set; }

    }
}
