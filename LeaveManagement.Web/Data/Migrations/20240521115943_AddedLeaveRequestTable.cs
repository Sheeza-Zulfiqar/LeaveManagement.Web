using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "77058461-9b73-46d4-925d-3c3b7e4ada91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "52ca455c-496b-4170-a690-2614fa12d77c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "117d80ba-1cac-4827-941f-1666d1c9a84b", "AQAAAAEAACcQAAAAEHhWz5xji94p0K8c1ma72XF1TLK8uTUI0gBuvch0Cmyib2tVty+x3aD1iVaMUwsqrQ==", "aec665c7-6aa9-4f48-befa-67ae9e67f173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45183b38-948a-4f8e-8083-e385eae91954", "AQAAAAEAACcQAAAAEBSYyW0OypYxyYEKT7nF2vThVywNiBLjw7LiJQ9KUTsTpQ3AA6cL4cInPlbvThIBTQ==", "527ed96e-1039-43cb-bef9-6a2814162409" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "987d8bbb-ff70-4e0a-aec6-9ad5bd44d29b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "640d904d-5290-497d-b7fc-6974efa31158");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8aaf020c-6e46-481a-a800-f7b58b7eb082", "AQAAAAEAACcQAAAAEIPrE0dolvhKdBhj2cWKfGFxYuJMuQ43haVMPN14LlVJVIGHGNpg9DYjc2OornbLHg==", "c418b715-65fa-4d11-92ce-01483066b237" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93c4aef0-76a6-4a1f-9923-4ffc05eed8fd", "AQAAAAEAACcQAAAAEHAu8UB5CIykImKSaSKcx5DKLoVVDAwwVo9+rq9cTQveAKtZsgEL/AwnAvpXWk4j5w==", "e2eb4f48-1a78-4ea0-8ad4-4b6116e4f0c0" });
        }
    }
}
