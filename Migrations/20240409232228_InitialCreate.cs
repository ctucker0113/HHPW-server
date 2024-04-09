using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW_server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsClosed = table.Column<bool>(type: "boolean", nullable: false),
                    PhoneNumber = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    OrderTypeID = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    Tip = table.Column<decimal>(type: "numeric", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserID = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Pulverizing Pepperoni Pizza", 12.99m },
                    { 2, "Spicy Buffalo Wings", 8.99m },
                    { 3, "Classic Margherita Pizza", 10.99m },
                    { 4, "BBQ Chicken Feast Pizza", 13.99m },
                    { 5, "Garlic Parmesan Wings", 9.49m }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Phone" },
                    { 2, "Online" },
                    { 3, "In Person" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "Date", "Email", "IsClosed", "Name", "OrderTypeID", "PhoneNumber", "Tip", "Total", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hurlyburlygirlie@gmail.com", false, "Gary's Order", 1, -9741, 10.90m, 22.55m, 1 },
                    { 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sarahsmail@example.com", true, "Sarah's Family Feast", 2, -8717, 5.00m, 35.20m, 2 },
                    { 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "john.doe@example.com", false, "John's Quick Lunch", 1, -1174, 3.00m, 15.99m, 3 },
                    { 4, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "emily.party@example.com", true, "Emily's Dinner Party", 2, -9142, 8.00m, 48.75m, 4 },
                    { 5, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "mike.games@example.com", false, "Mike's Game Night", 1, -6495, 6.00m, 30.40m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Name", "UID" },
                values: new object[,]
                {
                    { 1, "Harry Potter", "sampleName1" },
                    { 2, "Albus Dumbledore", "sampleName2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
