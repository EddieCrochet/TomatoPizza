using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TomatoPizzaCafe.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MakeYourOwns",
                columns: table => new
                {
                    MakeYourOwnId = table.Column<string>(nullable: false),
                    Topping = table.Column<string>(nullable: true),
                    Sauce = table.Column<string>(nullable: true),
                    Crust = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakeYourOwns", x => x.MakeYourOwnId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EightInchPrice = table.Column<double>(nullable: false),
                    TenInchPrice = table.Column<double>(nullable: false),
                    TwelveInchPrice = table.Column<double>(nullable: false),
                    FourteenInchPrice = table.Column<double>(nullable: false),
                    EighteenInchPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakeYourOwns");

            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
