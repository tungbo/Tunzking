using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunzking.DataAccess.Migrations
{
    public partial class testShoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ShoppingCarts",
                columns: new[] { "Id", "ApplicationUserId", "Count", "ProductId" },
                values: new object[] { 1, new Guid("380DB355-A18E-46D0-8A5B-08DBB6DAA972"), 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
