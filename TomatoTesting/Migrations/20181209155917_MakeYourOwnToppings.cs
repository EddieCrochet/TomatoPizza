using Microsoft.EntityFrameworkCore.Migrations;

namespace TomatoPizzaCafe.Migrations
{
    public partial class MakeYourOwnToppings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Topping",
                table: "MakeYourOwns",
                newName: "Toppings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Toppings",
                table: "MakeYourOwns",
                newName: "Topping");
        }
    }
}
