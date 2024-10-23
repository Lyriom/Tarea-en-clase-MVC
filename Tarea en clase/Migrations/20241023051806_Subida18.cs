using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea_en_clase.Migrations
{
    /// <inheritdoc />
    public partial class Subida18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEquipo",
                table: "Jugadores");

            migrationBuilder.AddColumn<string>(
                name: "NombreDeEquipo",
                table: "Jugadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreDeEquipo",
                table: "Jugadores");

            migrationBuilder.AddColumn<int>(
                name: "IdEquipo",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
