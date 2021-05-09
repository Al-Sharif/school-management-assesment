using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Infrastructure.Migrations
{
    public partial class isActiveremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6a4e500-5129-498e-af5d-1f6e3191d32f",
                column: "Name",
                value: "HumanResource");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07e43d65-5355-4fec-bc37-56d8534c48f8", "AQAAAAEAACcQAAAAEA2Kq8j+dx/kMW6EeX1ECj2NShLU/CsH1BUIKNBJSUKld0s/OKZKCUI+9/8p8xRWZA==", "fa0a4928-9a4e-4fd2-bc47-cfa70ffad8a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d394a6c1-6237-43b2-84eb-02397b01879e", "AQAAAAEAACcQAAAAEGWqxbA08TXL5GbChy+P65F/3QP4lMrDN1Gc+gMpDzWnK+eOQF42sUxY7SmQzSV8kg==", "b0225a11-115f-40b2-86f2-f51b8d99f4aa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6a4e500-5129-498e-af5d-1f6e3191d32f",
                column: "Name",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb804ed-8a2b-461e-a0b6-220cf0bd3ba3",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "743f2b20-2a43-474c-a801-660b4958c7e0", true, "AQAAAAEAACcQAAAAEHMyIp0Lu51GOBeBmqGQBYNRNWeJYLcIGBzsgdM/cVLEVuJfNePUH7FawSt6gedQsg==", "68e1e755-78d1-4973-af08-97f151290edb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da63bd40-0661-4fc3-9d7a-e0d397c027af",
                columns: new[] { "ConcurrencyStamp", "IsActive", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89002990-6d1e-4cfd-a7ab-68026350c97f", true, "AQAAAAEAACcQAAAAEIIvw3Ps9vp1dTr1WHdXLsp2FY1teu9ZL5j+thzjJCHqseAtU1d7fJwYJctK41R8bA==", "40f75d0b-6478-4951-a79b-ddd3a60da766" });
        }
    }
}
