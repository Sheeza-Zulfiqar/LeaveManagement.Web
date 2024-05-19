using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                    UserId= "f991baed-54a2-4b30-9817-794100d8a58e"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                    UserId = "a6b66d27-e2fa-4f99-9832-323509807c29"
                }
                );
        }

       
    }
}