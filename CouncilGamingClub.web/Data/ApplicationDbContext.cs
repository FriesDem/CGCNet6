using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CouncilGamingClub.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public DbSet<Customers> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Inventory> Inventory { get; set; }


    }
    z

}