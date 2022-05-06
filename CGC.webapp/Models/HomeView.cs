using CGC.webapp.Data;
using System.ComponentModel.DataAnnotations;

namespace CGC.webapp.Models
{
    public class HomeView
    {
        [Display(Name = "Total number of Orders")]
        public int TotalOrders { get; set; }

        [Display(Name = "Total number of Customers")]
        public int TotalCustomers { get; set; }

        [Display(Name = "Total number of Inventory")]
        public int TotalInventory { get; set; }

        public List<Customer>Customers { get; set; }

    }
}
