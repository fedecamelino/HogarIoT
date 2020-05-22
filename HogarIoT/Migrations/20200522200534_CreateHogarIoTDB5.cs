using Microsoft.EntityFrameworkCore.Migrations;

namespace HogarIoT.Migrations
{
    public partial class CreateHogarIoTDB5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Dispositivos");

            migrationBuilder.RenameColumn(
                name: "temperatura",
                table: "Dispositivos",
                newName: "Temperatura");

            migrationBuilder.AddColumn<int>(
                name: "ModoID",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoID",
                table: "Dispositivos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    EstadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionEstado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.EstadoID);
                });

            migrationBuilder.CreateTable(
                name: "Modos",
                columns: table => new
                {
                    ModoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionModo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modos", x => x.ModoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_ModoID",
                table: "Dispositivos",
                column: "ModoID");

            migrationBuilder.CreateIndex(
                name: "IX_Dispositivos_EstadoID",
                table: "Dispositivos",
                column: "EstadoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivos_Modos_ModoID",
                table: "Dispositivos",
                column: "ModoID",
                principalTable: "Modos",
                principalColumn: "ModoID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dispositivos_Estados_EstadoID",
                table: "Dispositivos",
                column: "EstadoID",
                principalTable: "Estados",
                principalColumn: "EstadoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivos_Modos_ModoID",
                table: "Dispositivos");

            migrationBuilder.DropForeignKey(
                name: "FK_Dispositivos_Estados_EstadoID",
                table: "Dispositivos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Modos");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivos_ModoID",
                table: "Dispositivos");

            migrationBuilder.DropIndex(
                name: "IX_Dispositivos_EstadoID",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "ModoID",
                table: "Dispositivos");

            migrationBuilder.DropColumn(
                name: "EstadoID",
                table: "Dispositivos");

            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "Dispositivos",
                newName: "temperatura");

            migrationBuilder.AddColumn<int>(
                name: "Mode",
                table: "Dispositivos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Dispositivos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
