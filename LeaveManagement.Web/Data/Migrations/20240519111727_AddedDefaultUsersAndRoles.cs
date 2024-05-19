using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4021dd58-9f7d-4820-af4d-bd8a17c3bca6", "722b76b8-fb43-4024-9399-cabf64088326", "Administrator", "ADMINISTRATOR" },
                    { "4121dd58-9f5d-4520-af4d-bda812c3bca7", "3d0317e4-ca2b-41b0-9d55-c7d5dfaf088d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LasttName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a6b66d27-e2fa-4f99-9832-323509807c29", 0, "60d4f750-5ded-49ff-9bc9-575cac4942bc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "user@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEHjPc4eytMZDouJuwt6rzNhcOlWY2GZgV3pej8ILuzkJ6FtDM1Qi9PdtMH84rdYP1g==", null, false, "f01369b6-d4ea-4404-ad7e-8d2b2bc37319", null, false, null },
                    { "f991baed-54a2-4b30-9817-794100d8a58e", 0, "7183966c-9c42-4cf0-acce-ee5ba13d232e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEO1sdBAYSfrapUPOHKmD1TZFkqMVOpEicO5dkemXF1m3FkueCLID9bm86qorqdnTPg==", null, false, "d130efd5-cd49-4e6f-860e-e0ef8d81326a", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4121dd58-9f5d-4520-af4d-bda812c3bca7", "a6b66d27-e2fa-4f99-9832-323509807c29" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4021dd58-9f7d-4820-af4d-bd8a17c3bca6", "f991baed-54a2-4b30-9817-794100d8a58e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4121dd58-9f5d-4520-af4d-bda812c3bca7", "a6b66d27-e2fa-4f99-9832-323509807c29" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4021dd58-9f7d-4820-af4d-bd8a17c3bca6", "f991baed-54a2-4b30-9817-794100d8a58e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e");
        }
    }
}
