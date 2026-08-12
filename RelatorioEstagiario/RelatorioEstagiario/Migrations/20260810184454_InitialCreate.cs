using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelatorioEstagiario.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relatorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semestre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpresaConcedente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormacaoSupervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroConselho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InicioEstagio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InicioPeriodoAvaliado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FimPeriodoAvaliado = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relatorios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relatorios");
        }
    }
}
