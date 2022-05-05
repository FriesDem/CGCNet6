
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGC.webapp.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cfc6ac6b-b6d4-42dc-b6ae-dabbaeed6969",
                    UserId = "afa2bb1c-a7a4-56bc-d6ba-baaeff4d5479"
                }
             );
        }
    }
}