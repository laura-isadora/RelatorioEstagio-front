using System;
using System.ComponentModel.DataAnnotations;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Models;

public partial class RelatorioEstagio
{
    // Pergunta 1
    [Required(ErrorMessage = "Campo obrigatório")]
    public string AtividadesVinculadas { get; set; } = string.Empty;

    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 2
    public string ContribuicaoFormacao { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 3
    public string AtualizacaoProfissional { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    // Pergunta 4
    public string SupervisaoAdequada { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]

    // Pergunta 5 - aspectos positivos
    public string AspectoPositivo1 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string AspectoPositivo2 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string AspectoPositivo3 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]

    // Pergunta 6 - aspectos negativos
    public string AspectoNegativo1 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string AspectoNegativo2 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string AspectoNegativo3 { get; set; } = string.Empty;


    // Satisfação pessoal
    [Range(1,10)]
    public int? Satisfacao { get; set; }
}