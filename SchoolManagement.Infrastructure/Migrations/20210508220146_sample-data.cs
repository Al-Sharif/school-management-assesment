using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Infrastructure.Migrations
{
    public partial class sampledata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63804a41-a74f-427b-9050-a0d6da67c9ff", "1", "Staff", "Staff" },
                    { "d6a4e500-5129-498e-af5d-1f6e3191d32f", "2", "HR", "Human Resource" },
                    { "8c896fa0-220b-42df-a9fd-57c607e44959", "3", "Student", "Student" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3", 0, "97075312-b99f-4b11-9edc-62ab4995f73e", "staff@gmail.com", false, "Majdi", true, "Mohammad", false, null, null, null, null, "1234567890", false, "b5f92150-870a-4f78-ad87-2cf00e370c78", false, "Staff" },
                    { "da63bd40-0661-4fc3-9d7a-e0d397c027af", 0, "5c5ae4ff-333c-4fd8-84ce-0759f2ef20c1", "hr@gmail.com", false, "Human", true, "Resource", false, null, null, null, null, "1234567890", false, "ad19c30d-c726-484b-ad8f-cf5700df99ff", false, "Human_Resource" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "63804a41-a74f-427b-9050-a0d6da67c9ff", "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6a4e500-5129-498e-af5d-1f6e3191d32f", "da63bd40-0661-4fc3-9d7a-e0d397c027af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c896fa0-220b-42df-a9fd-57c607e44959");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "63804a41-a74f-427b-9050-a0d6da67c9ff", "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6a4e500-5129-498e-af5d-1f6e3191d32f", "da63bd40-0661-4fc3-9d7a-e0d397c027af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63804a41-a74f-427b-9050-a0d6da67c9ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6a4e500-5129-498e-af5d-1f6e3191d32f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af");
        }
    }
}
