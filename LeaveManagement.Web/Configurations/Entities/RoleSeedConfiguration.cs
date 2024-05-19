using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { 
                    Id= "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                    Name=Roles.Administrator,
                    NormalizedName= Roles.Administrator.ToUpper()
                }, 
                new IdentityRole
                {
                    Id = "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }

                );
        }
    }
}