using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeluCore.Migrations
{
    /// <inheritdoc />
    public partial class AgregarDni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DNI",
                table: "Clientes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DNI",
                table: "Clientes");
        }
    }
}
