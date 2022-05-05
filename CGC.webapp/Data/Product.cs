using System.ComponentModel.DataAnnotations.Schema;

namespace CGC.webapp.Data
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
    }
}
