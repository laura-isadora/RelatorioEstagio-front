using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioEstagiario.Migrations
{
    /// <inheritdoc />
    public partial class CrirarRelatorio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AspectoNegativo1",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspectoNegativo2",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspectoNegativo3",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspectoPositivo1",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspectoPositivo2",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AspectoPositivo3",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Assiduidade",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AtividadesVinculadas",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AtualizacaoProfissional",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContribuicaoFormacao",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DominioTecnico",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpenhoDinamismo",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FacilidadeEspontaneidade",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OutrosAspectos",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "QualidadeEficaciaPrazos",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelacionamentoColegas",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RelacionamentoOrientador",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Satisfacao",
                table: "Relatorios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisaoAdequada",
                table: "Relatorios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AspectoNegativo1",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AspectoNegativo2",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AspectoNegativo3",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AspectoPositivo1",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AspectoPositivo2",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AspectoPositivo3",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Assiduidade",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AtividadesVinculadas",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "AtualizacaoProfissional",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "ContribuicaoFormacao",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "DominioTecnico",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "EmpenhoDinamismo",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "FacilidadeEspontaneidade",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "OutrosAspectos",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "QualidadeEficaciaPrazos",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "RelacionamentoColegas",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "RelacionamentoOrientador",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "Satisfacao",
                table: "Relatorios");

            migrationBuilder.DropColumn(
                name: "SupervisaoAdequada",
                table: "Relatorios");
        }
    }
}
