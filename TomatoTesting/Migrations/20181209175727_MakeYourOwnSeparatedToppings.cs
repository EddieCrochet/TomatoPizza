using Microsoft.EntityFrameworkCore.Migrations;

namespace TomatoPizzaCafe.Migrations
{
    public partial class MakeYourOwnSeparatedToppings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Toppings",
                table: "MakeYourOwns");

            migrationBuilder.AddColumn<bool>(
                name: "blackOlives",
                table: "MakeYourOwns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "greenPeppers",
                table: "MakeYourOwns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "mushrooms",
                table: "MakeYourOwns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "pepperoni",
                table: "MakeYourOwns",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "sausage",
                table: "MakeYourOwns",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "blackOlives",
                table: "MakeYourOwns");

            migrationBuilder.DropColumn(
                name: "greenPeppers",
                table: "MakeYourOwns");

            migrationBuilder.DropColumn(
                name: "mushrooms",
                table: "MakeYourOwns");

            migrationBuilder.DropColumn(
                name: "pepperoni",
                table: "MakeYourOwns");

            migrationBuilder.DropColumn(
                name: "sausage",
                table: "MakeYourOwns");

            migrationBuilder.AddColumn<string>(
                name: "Toppings",
                table: "MakeYourOwns",
                nullable: true);
        }
    }
}
