using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ExtendedUserTableLastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LasttName",
                table: "AspNetUsers",
                newName: "LastName");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "LasttName");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "481721b3-7d15-4c23-8dd7-91f4a293ec1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "d5def0e1-71d2-4bd8-a50d-6397b5421ecf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2962397-41e9-4f62-b390-89c24377997a", "AQAAAAEAACcQAAAAEI4tmNXWhwFmzp5OzRNpZan9ceiLUm3kkp+quesyaThuQLEIpRmiKt5AoykePhrSgw==", "43f736bb-88d5-4223-9c2a-7278e87a762c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0e4eb1a-1634-4f3d-b345-7d693278d665", "AQAAAAEAACcQAAAAEMk6bC9S8ee3Ej1s8Xv4fQAKFu7G+nT7ZsstK0hdnxwbDaCmosUTPL+Qh9AA/9GWew==", "9c8a3b24-0469-474e-a431-da7484adb4f8" });
        }
    }
}
