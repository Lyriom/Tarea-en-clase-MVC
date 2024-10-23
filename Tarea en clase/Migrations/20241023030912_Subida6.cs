using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea_en_clase.Migrations
{
    /// <inheritdoc />
    public partial class Subida6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estadio",
                newName: "IdEstadio");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipo",
                newName: "IdEquipo");

            migrationBuilder.AddColumn<string>(
                name: "IdEquipo",
                table: "Jugadores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdEstadio",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEquipo",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "IdEstadio",
                table: "Equipo");

            migrationBuilder.RenameColumn(
                name: "IdEstadio",
                table: "Estadio",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdEquipo",
                table: "Equipo",
                newName: "Id");
        }
    }
}
