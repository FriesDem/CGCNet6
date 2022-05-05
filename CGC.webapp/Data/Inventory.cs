using System.ComponentModel.DataAnnotations.Schema;

namespace CGC.webapp.Data
{
    public class Inventory
    {
        public int Id { get; set; }
        public int InventoryID { get; set; }

        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }
}
