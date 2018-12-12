using Microsoft.EntityFrameworkCore.Migrations;

namespace TomatoPizzaCafe.Migrations
{
    public partial class AddedNumberOfPies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfPies",
                table: "Pizzas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPies",
                table: "MakeYourOwns",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfPies",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "NumberOfPies",
                table: "MakeYourOwns");
        }
    }
}
