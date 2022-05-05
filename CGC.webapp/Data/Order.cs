using System.ComponentModel.DataAnnotations.Schema;

namespace CGC.webapp.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int CCGC { get; set; }  
        public string ProductName { get; set; }


    }
}
