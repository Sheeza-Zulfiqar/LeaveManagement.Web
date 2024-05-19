using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b886d252-014c-48cd-b11c-6b0348ff084e", true, "user@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMxExYTCyY3lns5+R+xIbskS7nMbLLTbSOy9ngPyeA+gb92o+rodYdJOaWA2J5Fmcg==", "bb45b786-ca8a-45ef-a465-00582e3f13cb", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d8e5b67a-86dd-4782-8227-394fdc10cd5f", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBiSt08t/BhL7c6EaH+CnKSsZDg4YnHms8hYFp50hQf3uI7z/osEUKgpo6ecuuPMwQ==", "0efe4b02-49d6-475a-850f-1ab5c67c5b26", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "722b76b8-fb43-4024-9399-cabf64088326");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "3d0317e4-ca2b-41b0-9d55-c7d5dfaf088d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "60d4f750-5ded-49ff-9bc9-575cac4942bc", false, null, "AQAAAAEAACcQAAAAEHjPc4eytMZDouJuwt6rzNhcOlWY2GZgV3pej8ILuzkJ6FtDM1Qi9PdtMH84rdYP1g==", "f01369b6-d4ea-4404-ad7e-8d2b2bc37319", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7183966c-9c42-4cf0-acce-ee5ba13d232e", false, null, "AQAAAAEAACcQAAAAEO1sdBAYSfrapUPOHKmD1TZFkqMVOpEicO5dkemXF1m3FkueCLID9bm86qorqdnTPg==", "d130efd5-cd49-4e6f-860e-e0ef8d81326a", null });
        }
    }
}
