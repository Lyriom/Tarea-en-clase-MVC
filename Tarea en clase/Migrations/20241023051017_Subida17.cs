using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tarea_en_clase.Migrations
{
    /// <inheritdoc />
    public partial class Subida17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEstadio",
                table: "Equipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdEstadio",
                table: "Equipo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
