using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioEstagiario.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTokenRedefinicao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TokenRedefinicao",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenRedefinicaoExpiraEm",
                table: "Usuarios",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TokenRedefinicao",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "TokenRedefinicaoExpiraEm",
                table: "Usuarios");
        }
    }
}
