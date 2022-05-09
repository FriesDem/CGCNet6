using System.ComponentModel.DataAnnotations;

namespace CGC.webapp.Data
{
    public class Customer
    {
        
        public int Id { get; set; }

        [Required]
        [Range(1, 99999)]
        public int CCGC { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }


        public int PhoneNumber { get; set; }

    }
}
