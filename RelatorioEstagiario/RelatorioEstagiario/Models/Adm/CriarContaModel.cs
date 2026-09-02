using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models.Adm
{
    public class CriarContaModel
    {
        public string Token { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o usúario.")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres.")]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirme sua senha.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmarSenha { get; set; } = string.Empty;
    }
}
