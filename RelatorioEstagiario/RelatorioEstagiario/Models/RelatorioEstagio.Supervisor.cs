using System;
using System.ComponentModel.DataAnnotations;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Models;

public partial class RelatorioEstagio
{
    // Pergunta 1
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Assiduidade { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 2
    public string EmpenhoDinamismo { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 3
    public string QualidadeEficaciaPrazos { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 4
    public string DominioTecnico { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 5
    public string RelacionamentoOrientador { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 6
    public string RelacionamentoColegas { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 7
    public string FacilidadeEspontaneidade { get; set; } = string.Empty;

    // Pergunta 8
    public string OutrosAspectos { get; set; } = string.Empty;
}