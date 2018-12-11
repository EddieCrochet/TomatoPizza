﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TomatoPizzaCafe.Migrations.Application
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ToppingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ToppingID);
                });

            migrationBuilder.CreateTable(
                name: "MakeYourOwns",
                columns: table => new
                {
                    MakeYourOwnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sauce = table.Column<string>(nullable: true),
                    Crust = table.Column<string>(nullable: true),
                    Topping1 = table.Column<string>(nullable: true),
                    Topping2 = table.Column<string>(nullable: true),
                    Topping3 = table.Column<string>(nullable: true),
                    Topping4 = table.Column<string>(nullable: true),
                    Topping5 = table.Column<string>(nullable: true),
                    Topping6 = table.Column<string>(nullable: true),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwns", x => x.MakeYourOwnID);
                    table.ForeignKey(
                        name: "FK_MakeYourOwns_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EightInchPrice = table.Column<double>(nullable: false),
                    TenInchPrice = table.Column<double>(nullable: false),
                    TwelveInchPrice = table.Column<double>(nullable: false),
                    FourteenInchPrice = table.Column<double>(nullable: false),
                    EighteenInchPrice = table.Column<double>(nullable: false),
                    OrderID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaID);
                    table.ForeignKey(
                        name: "FK_Pizzas_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MakeYourOwns_OrderID",
                table: "MakeYourOwns",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_OrderID",
                table: "Pizzas",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakeYourOwns");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}