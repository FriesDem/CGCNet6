using CGC.webapp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGC.webapp.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479",
                    Email = "admin@CGC.com",
                    NormalizedEmail = "ADMIN@CGC.COM",
                    NormalizedUserName = "ADMIN@CGC.COM",
                    UserName = "admin@cgc.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "@dmin1"),
                    EmailConfirmed = true
                }
             );
            
        }
    }
}