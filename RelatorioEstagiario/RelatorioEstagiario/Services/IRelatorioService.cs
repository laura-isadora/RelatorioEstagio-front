using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Services;

public interface IRelatorioService
{
    Task CriarAsync(RelatorioEstagio relatorio);

    Task<List<RelatorioEstagio>> ListAsync();

    Task<RelatorioEstagio?> BuscarAsync(int id);

    Task AtualizarAsync(RelatorioEstagio relatorio);

    Task ExcluirAsync(int id);
}