using System.ComponentModel.DataAnnotations.Schema;

namespace CouncilGamingClub.web.Data
{
    public class Orders
    {
        public int Id { get; set; }

        [ForeignKey("Customersccgc")]

      public Customers Customers { get; set; }
        public int Customersccgc { get; set; }

        public float OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }

        public int OrderNumber { get; set; }

        [ForeignKey("InventoryProductName")]
        public Inventory Inventory { get; set; }
        public string InventoryProductName { get; set; }



    }
}
