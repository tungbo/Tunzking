using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunzking.DataAccess.Migrations
{
    public partial class addSessionIdToOrderHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: new Guid("05603c0f-db11-41b8-92c2-6fc01850c714"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "OrderHeaders");

            migrationBuilder.UpdateData(
                table: "ShoppingCarts",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: new Guid("a9927a75-c755-4013-8add-c27831308871"));
        }
    }
}
