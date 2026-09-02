using System;
using System.ComponentModel.DataAnnotations;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Models;

public partial class RelatorioEstagio
{
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Atividade1 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Atividade2 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Atividade3 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Atividade4 { get; set; } = string.Empty;
    [Required(ErrorMessage = "Campo obrigatório")]
    public string Atividade5 { get; set; } = string.Empty;
}