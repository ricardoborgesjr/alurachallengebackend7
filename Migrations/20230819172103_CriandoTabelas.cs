using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace alurachallengebackend7.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Destinos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Foto2",
                table: "Destinos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Meta",
                table: "Destinos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Destinos");

            migrationBuilder.DropColumn(
                name: "Foto2",
                table: "Destinos");

            migrationBuilder.DropColumn(
                name: "Meta",
                table: "Destinos");
        }
    }
}
