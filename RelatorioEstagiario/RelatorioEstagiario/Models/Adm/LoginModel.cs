using System.ComponentModel.DataAnnotations;

namespace RelatorioEstagiario.Models.Adm
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Informe o usuário.")]
        public string Usuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "Informe a senha.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; } = string.Empty;

    }
}
