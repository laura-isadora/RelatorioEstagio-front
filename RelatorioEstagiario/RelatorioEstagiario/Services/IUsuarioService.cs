using RelatorioEstagiario.Models.Adm;

namespace RelatorioEstagiario.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioModel?> BuscarPorLoginAsync(string usuario, string senha);
        Task<UsuarioModel?> BuscarPorEmailAsync(string email);
        Task<bool> EmailExistenteAsync(string email);
        Task<string?> GerarTokenRedefinicaoAsync(string email);
        Task<UsuarioModel> BuscarPorTokenAsync(string token);
        Task<bool> RedefinirSenhaAsync(string token, string novaSenha);
    }
}
