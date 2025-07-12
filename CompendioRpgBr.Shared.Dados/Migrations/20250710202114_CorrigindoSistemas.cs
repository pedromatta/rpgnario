using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompendioRpgBr.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class CorrigindoSistemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Editoras",
                keyColumn: "Foto",
                keyValue: null,
                column: "Foto",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Editoras",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Editoras",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
