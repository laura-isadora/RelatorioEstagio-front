using RelatorioEstagiario.Models.Adm;

namespace RelatorioEstagiario.Services
{
    public interface ILoginService
    {
       Task<UsuarioModel?> LoginAsync(string usuario, string senha);
    }
}
