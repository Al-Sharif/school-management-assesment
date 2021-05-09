using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Infrastructure.Migrations
{
    public partial class registrationrequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistrationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationRequests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd381a9-954f-4fd4-a5f8-147112bf5749", "STAFF@GMAIL.COM", "STAFF", "AQAAAAEAACcQAAAAEMlGUYAc13tRwmxCoL8NbHXRZGZBsJo1mDS9ovTMdHykWp2+FOwLvK1IqOiChU2uHg==", "94e138f0-72c7-4efc-b068-1108e55c4cf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d40bdc-c6de-4ccd-9d5e-9a3b39867f6f", "HR@GMAIL.COM", "HUMAN_RESOURCE", "AQAAAAEAACcQAAAAEP/dHSIqxWS9Gu+xDX0iWt1iSqt8viI+wdDvV/DMvBIMOBv2nA8GUnRzSitA3ALO5Q==", "9a5a0327-f7a6-4af8-94f9-9d51783ffd95" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistrationRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eda12071-4507-45cf-a0c4-bc2f179b3948", null, null, "AQAAAAEAACcQAAAAELvZ/DybXUCLJh6/Av397yChA0Z59+dwcf6vlPdZY8KK6dfBhc7Sa5+/EZi2HSJw6A==", "7fa3e950-385c-429b-b6bb-520b8e9b7f77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7771eed-7cc1-40a3-b898-b9556160f737", null, null, "AQAAAAEAACcQAAAAEKAUcsb4DBujmVZ+nzMMbievNqypmUT9d/PcrhITV9nU+ZB8ddaBO9yC5hH4I6C2+Q==", "622fa7b4-25e6-406d-9ad1-322359641c02" });
        }
    }
}
