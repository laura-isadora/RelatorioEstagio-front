using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models.Adm
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Usuário é obrigatório.")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string SenhaHash { get; set; } = string.Empty;

        public string Perfil { get; set; } = "Admin";

        [Required(ErrorMessage = "E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido.")]
        public string Email { get; set; } = string.Empty;

        public string? TokenCadastro { get; set; }

        public DateTime? TokenCadastroExpiraEm { get; set; }
    }
}
