using Microsoft.AspNetCore.Identity;

namespace CouncilGamingClub.web.Data
{
    public class Employee : IdentityUser
    {
      
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string EmpID { get; set; }

        public DateTime DOB { get; set; }

    }
}
