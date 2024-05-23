using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedLeaveRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4021dd58-9f7d-4820-af4d-bd8a17c3bca6",
                column: "ConcurrencyStamp",
                value: "316156c6-5f9b-4770-85eb-cfd616876844");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4121dd58-9f5d-4520-af4d-bda812c3bca7",
                column: "ConcurrencyStamp",
                value: "ba9171dc-085a-49b9-9f0d-bc6e8bac11c9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6b66d27-e2fa-4f99-9832-323509807c29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd4c94c6-5b0a-4932-b251-aee298e31c30", "AQAAAAEAACcQAAAAEBiwRaHDHeWmrQ8NMIM0b4cmuMpL2V7sPNw86TvETo67Z5c14fFkPbq+3vNP3N/GZA==", "1d42bbb5-6190-4012-b46e-d69e43bcfd1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f991baed-54a2-4b30-9817-794100d8a58e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5ad92eb-7d2e-482f-9c07-063080a0980e", "AQAAAAEAACcQAAAAEGUPfvTiPNfyI60ASEvqnsY4VSg8gl90vRAtj13JWIC34f+yTs2Qi3/4ODqj0hI+gA==", "89302b2c-16f7-475d-a951-0cb71ce58c8f" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequest",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequest");

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
    }
}
