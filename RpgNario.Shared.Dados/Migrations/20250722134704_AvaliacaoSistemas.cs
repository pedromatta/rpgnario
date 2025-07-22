using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgNario.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AvaliacaoSistemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvaliacaoSistemas",
                columns: table => new
                {
                    SistemaId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoSistemas", x => new { x.SistemaId, x.PessoaId });
                    table.ForeignKey(
                        name: "FK_AvaliacaoSistemas_Sistemas_SistemaId",
                        column: x => x.SistemaId,
                        principalTable: "Sistemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvaliacaoSistemas");
        }
    }
}
