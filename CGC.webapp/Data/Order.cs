using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CGC.webapp.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }

        [Required]
        [Range(1, 99999)]
        public int CCGC { get; set; }  
        public string ProductName { get; set; }


    }
}
