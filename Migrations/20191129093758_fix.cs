using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dutch_Treat.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 1, new DateTime(2019, 11, 27, 16, 11, 7, 536, DateTimeKind.Utc).AddTicks(4515), "12345" });
        }
    }
}
