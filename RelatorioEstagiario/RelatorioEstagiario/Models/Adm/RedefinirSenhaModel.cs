using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models.Adm
{
    public class RedefinirSenhaModel
    {
        public string Token { get; set; } = string.Empty;

        [Required(ErrorMessage = "A nova senha é obrigatória.")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        public string NovaSenha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme sua senha.")]
        [Compare(
            "NovaSenha",
            ErrorMessage = "As senhas não coincidem."
        )]
        public string ConfirmarSenha { get; set; } = string.Empty;
    }
}
