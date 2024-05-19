using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher= new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "f991baed-54a2-4b30-9817-794100d8a58e",
                    Email= "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    FirstName = "System",
                    LasttName ="Admin",
                    PasswordHash=hasher.HashPassword(null,"Pakist@n12"),
                    EmailConfirmed=true
                },
                new Employee
                {
                    Id = "a6b66d27-e2fa-4f99-9832-323509807c29",
                    Email = "user@localhost.com",
                    NormalizedEmail = "user@LOCALHOST.COM",
                    NormalizedUserName = "user@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    FirstName = "System",
                    LasttName = "User",
                    PasswordHash = hasher.HashPassword(null, "Pakist@n12"),
                    EmailConfirmed=true
                }

                );
        }
    }
    
}