using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Infrastructure.Migrations
{
    public partial class isApprovednullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "RegistrationRequests",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "743f2b20-2a43-474c-a801-660b4958c7e0", "AQAAAAEAACcQAAAAEHMyIp0Lu51GOBeBmqGQBYNRNWeJYLcIGBzsgdM/cVLEVuJfNePUH7FawSt6gedQsg==", "68e1e755-78d1-4973-af08-97f151290edb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89002990-6d1e-4cfd-a7ab-68026350c97f", "AQAAAAEAACcQAAAAEIIvw3Ps9vp1dTr1WHdXLsp2FY1teu9ZL5j+thzjJCHqseAtU1d7fJwYJctK41R8bA==", "40f75d0b-6478-4951-a79b-ddd3a60da766" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsApproved",
                table: "RegistrationRequests",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dd381a9-954f-4fd4-a5f8-147112bf5749", "AQAAAAEAACcQAAAAEMlGUYAc13tRwmxCoL8NbHXRZGZBsJo1mDS9ovTMdHykWp2+FOwLvK1IqOiChU2uHg==", "94e138f0-72c7-4efc-b068-1108e55c4cf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d40bdc-c6de-4ccd-9d5e-9a3b39867f6f", "AQAAAAEAACcQAAAAEP/dHSIqxWS9Gu+xDX0iWt1iSqt8viI+wdDvV/DMvBIMOBv2nA8GUnRzSitA3ALO5Q==", "9a5a0327-f7a6-4af8-94f9-9d51783ffd95" });
        }
    }
}
