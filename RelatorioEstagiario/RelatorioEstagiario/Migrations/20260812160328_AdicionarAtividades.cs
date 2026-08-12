using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioEstagiario.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarAtividades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Departamento",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Atividade1",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Atividade2",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Atividade3",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Atividade4",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Atividade5",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atividade1",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Atividade2",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Atividade3",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Atividade4",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Atividade5",
                table: "Relatorios");

            migrationBuilder.AlterColumn<string>(
                name: "Departamento",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
