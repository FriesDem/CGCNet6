using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGC.webapp.Web.Configuration.Entities
{

    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                    Name = "administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "bad4ac6e-c6d3-42ac-b3be-dabbaaec6769",
                    Name = "user",
                    NormalizedName = "USER"
                }
                );
        }
    }
}