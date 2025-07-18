using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgNario.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class RelacionandoMusicaGenero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneroSistema",
                columns: table => new
                {
                    GenerosId = table.Column<int>(type: "int", nullable: false),
                    SistemasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroSistema", x => new { x.GenerosId, x.SistemasId });
                    table.ForeignKey(
                        name: "FK_GeneroSistema_Generos_GenerosId",
                        column: x => x.GenerosId,
                        principalTable: "Generos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroSistema_Sistemas_SistemasId",
                        column: x => x.SistemasId,
                        principalTable: "Sistemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroSistema_SistemasId",
                table: "GeneroSistema",
                column: "SistemasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneroSistema");
        }
    }
}
