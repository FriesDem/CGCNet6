using System.ComponentModel.DataAnnotations;

namespace CGC.webapp.Data
{
    public class Supplier
    {
        public int Id { get; set; }
        public int? SupplierID { get; set; }
        public string? SupplierName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public int? Phone { get; set; }

    }
}
