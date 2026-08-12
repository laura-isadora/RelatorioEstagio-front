using Microsoft.EntityFrameworkCore;
using RelatorioEstagiario.Data;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Services;

public class RelatorioService : IRelatorioService
{
    private readonly ApplicationDbContext _context;

    public RelatorioService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task CriarAsync(RelatorioEstagio relatorio)
    {
        _context.Relatorios.Add(relatorio);

        await _context.SaveChangesAsync();
    }

    public async Task<List<RelatorioEstagio>> ListAsync()
    {
        return await _context.Relatorios.ToListAsync();
    }

    public async Task<RelatorioEstagio?> BuscarAsync(int id)
    {
        return await _context.Relatorios
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AtualizarAsync(RelatorioEstagio relatorio)
    {
        var existente = await _context.Relatorios
            .FirstOrDefaultAsync(x => x.Id == relatorio.Id);

        if (existente == null)
        {
            return;
        }

        _context.Entry(existente).CurrentValues.SetValues(relatorio);

        await _context.SaveChangesAsync();
    }

    public async Task ExcluirAsync(int id)
    {
        var relatorio = await BuscarAsync(id);

        if (relatorio != null)
        {
            _context.Relatorios.Remove(relatorio);

            await _context.SaveChangesAsync();
        }
    }
}