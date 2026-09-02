using Microsoft.EntityFrameworkCore;
using RelatorioEstagiario.Models;
using RelatorioEstagiario.Models.Adm;

namespace RelatorioEstagiario.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<RelatorioEstagio> Relatorios { get; set; }
    
    public DbSet<UsuarioModel> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UsuarioModel>().HasIndex(x => x.Email).IsUnique(); ;
    }
}