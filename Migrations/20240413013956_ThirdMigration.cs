using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HHPW_server.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 1,
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 2,
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 3,
                column: "Quantity",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 4,
                column: "Quantity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "ID",
                keyValue: 5,
                column: "Quantity",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderItems");
        }
    }
}
