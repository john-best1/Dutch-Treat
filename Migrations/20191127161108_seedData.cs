using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dutch_Treat.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2019, 11, 27, 16, 11, 7, 536, DateTimeKind.Utc).AddTicks(4515));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2019, 11, 27, 15, 50, 59, 963, DateTimeKind.Utc).AddTicks(5347));
        }
    }
}
