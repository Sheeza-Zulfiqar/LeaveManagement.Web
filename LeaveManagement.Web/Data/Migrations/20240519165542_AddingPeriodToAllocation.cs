using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "1a6eebe4-8daf-4ba8-b738-bdf1426c57d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "c57cbd01-008c-409b-8e9d-c8719f5106bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b886d252-014c-48cd-b11c-6b0348ff084e", "AQAAAAEAACcQAAAAEMxExYTCyY3lns5+R+xIbskS7nMbLLTbSOy9ngPyeA+gb92o+rodYdJOaWA2J5Fmcg==", "bb45b786-ca8a-45ef-a465-00582e3f13cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8e5b67a-86dd-4782-8227-394fdc10cd5f", "AQAAAAEAACcQAAAAEBiSt08t/BhL7c6EaH+CnKSsZDg4YnHms8hYFp50hQf3uI7z/osEUKgpo6ecuuPMwQ==", "0efe4b02-49d6-475a-850f-1ab5c67c5b26" });
        }
    }
}
