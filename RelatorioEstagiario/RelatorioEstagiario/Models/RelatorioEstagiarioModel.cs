using System;
using System.ComponentModel.DataAnnotations;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Models;

public partial class RelatorioEstagio
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Matricula { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Curso { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Semestre { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string IE { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string EmpresaConcedente { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string NomeSupervisor { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string FormacaoSupervisor { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string RegistroConselho { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string? Departamento { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Cargo { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public DateTime? InicioEstagio { get; set; }
    [Required(ErrorMessage = "Campo obrigatório")]
    public DateTime? InicioPeriodoAvaliado { get; set; }
    [Required(ErrorMessage = "Campo obrigatório")]
    public DateTime? FimPeriodoAvaliado { get; set; }
}