using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Infrastructure.Migrations
{
    public partial class sampledatapassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eda12071-4507-45cf-a0c4-bc2f179b3948", "AQAAAAEAACcQAAAAELvZ/DybXUCLJh6/Av397yChA0Z59+dwcf6vlPdZY8KK6dfBhc7Sa5+/EZi2HSJw6A==", "7fa3e950-385c-429b-b6bb-520b8e9b7f77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7771eed-7cc1-40a3-b898-b9556160f737", "AQAAAAEAACcQAAAAEKAUcsb4DBujmVZ+nzMMbievNqypmUT9d/PcrhITV9nU+ZB8ddaBO9yC5hH4I6C2+Q==", "622fa7b4-25e6-406d-9ad1-322359641c02" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97075312-b99f-4b11-9edc-62ab4995f73e", null, "b5f92150-870a-4f78-ad87-2cf00e370c78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c5ae4ff-333c-4fd8-84ce-0759f2ef20c1", null, "ad19c30d-c726-484b-ad8f-cf5700df99ff" });
        }
    }
}
