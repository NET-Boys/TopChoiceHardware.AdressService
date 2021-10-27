using Microsoft.EntityFrameworkCore.Migrations;

namespace TopChoiceHardware.AdressService.AccessData.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Domicilio");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Domicilio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Domicilio",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Domicilio",
                type: "int",
                nullable: true);
        }
    }
}
