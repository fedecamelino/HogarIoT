using Microsoft.EntityFrameworkCore.Migrations;

namespace HogarIoT.Migrations
{
    public partial class CreateHogarIoTDB4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mode",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "temperatura",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Grabar",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Dispositivos",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TempFreezer",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TempHeladera",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Intensidad",
                table: "Dispositivos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "temperatura",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "Grabar",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "TempFreezer",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "TempHeladera",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "Intensidad",
                table: "Dispositivos");
        }
    }
}
