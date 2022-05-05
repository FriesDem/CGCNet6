using Microsoft.AspNetCore.Identity;

namespace CGC.webapp.Data
{
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }
        public DateTime Dateofbirth { get; set; }
        public DateTime Datejoined { get; set; }


    }
}
