﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompendioRpgBr.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoFotonosSistemas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Sistemas",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Sistemas");
        }
    }
}
