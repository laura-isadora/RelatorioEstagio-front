using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models;

public partial class RelatorioEstagio
{
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; } = string.Empty;

    public string Matricula { get; set; } = string.Empty;

    public string Curso { get; set; } = string.Empty;

    public string Semestre { get; set; } = string.Empty;

    public string IE { get; set; } = string.Empty;

    public string EmpresaConcedente { get; set; } = string.Empty;

    public string NomeSupervisor { get; set; } = string.Empty;

    public string FormacaoSupervisor { get; set; } = string.Empty;

    public string RegistroConselho { get; set; } = string.Empty;

    public string? Departamento { get; set; } = string.Empty;

    public string Cargo { get; set; } = string.Empty;

    public DateTime? InicioEstagio { get; set; }

    public DateTime? InicioPeriodoAvaliado { get; set; }

    public DateTime? FimPeriodoAvaliado { get; set; }
}