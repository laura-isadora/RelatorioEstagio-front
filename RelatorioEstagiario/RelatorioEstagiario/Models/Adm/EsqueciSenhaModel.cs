using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models.Adm
{
    public class EsqueciSenhaModel
    {
        [Required(ErrorMessage = "Informe o e-mail.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]

        public string Email { get; set; } = string.Empty;
    }
}
