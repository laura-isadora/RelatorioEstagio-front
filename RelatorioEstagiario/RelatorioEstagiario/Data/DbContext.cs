using Microsoft.EntityFrameworkCore;
using RelatorioEstagiario.Models;

namespace RelatorioEstagiario.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<RelatorioEstagio> Relatorios { get; set; }
}