using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgNario.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoImagens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Editoras",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Editoras");
        }
    }
}
