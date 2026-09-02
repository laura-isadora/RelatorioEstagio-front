using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RelatorioEstagiario.Data;
using RelatorioEstagiario.Models.Adm;
using System.Security.Cryptography;

namespace RelatorioEstagiario.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;
        private readonly PasswordHasher<UsuarioModel> _passwordHasher;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<UsuarioModel>();
        }

        public void GerarHashTeste()
        {
            var usuario = new UsuarioModel
            {
                Usuario = "admin",
                Perfil = "Admin",
                Email = "admin@email.com"
            };

            var hash = _passwordHasher.HashPassword(
                usuario,
                "123456"
            );

            Console.WriteLine("HASH:");
            Console.WriteLine(hash);
        }


        public async Task<UsuarioModel?> BuscarPorEmailAsync(string email)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<bool> EmailExisteAsync(string email)
        {
            return await _context.Usuarios
                .AnyAsync(x => x.Email == email);
        }

        public async Task<UsuarioModel?> BuscarPorLoginAsync(
            string usuario,
            string senha)
        {
            var usuarioEncontrado = await _context.Usuarios
                .FirstOrDefaultAsync(x => x.Usuario == usuario);

            if (usuarioEncontrado == null)
            {
                return null;
            }

            var resultado = _passwordHasher.VerifyHashedPassword(
                usuarioEncontrado,
                usuarioEncontrado.SenhaHash,
                senha
            );

            if (resultado == PasswordVerificationResult.Success)
            {
                return usuarioEncontrado;
            }

            return null;
        }

        public async Task<string?> GerarTokenRedefinicaoAsync(string email)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(x => x.Email == email);

            if (usuario == null)
            {
                return null;
            }

            var tokenBytes = RandomNumberGenerator.GetBytes(32);

            var token = Convert.ToBase64String(tokenBytes)
                .Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");

            usuario.TokenCadastro = token;

            // Token válido por 30 minutos
            usuario.TokenCadastroExpiraEm =
                DateTime.UtcNow.AddMinutes(30);

            await _context.SaveChangesAsync();

            return token;
        }

        public async Task<UsuarioModel?> BuscarPorTokenAsync(string token)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(x =>
                    x.TokenCadastro == token);

            if (usuario == null)
            {
                return null;
            }

            if (usuario.TokenCadastroExpiraEm == null)
            {
                return null;
            }

            if (usuario.TokenCadastroExpiraEm < DateTime.UtcNow)
            {
                return null;
            }

            return usuario;
        }

        public async Task<bool> RedefinirSenhaAsync(
            string token,
            string novaSenha)
        {
            var usuario = await BuscarPorTokenAsync(token);

            if (usuario == null)
            {
                return false;
            }

            usuario.SenhaHash = _passwordHasher.HashPassword(
                usuario,
                novaSenha
            );

            // Invalida o token depois de usado
            usuario.TokenCadastro = null;
            usuario.TokenCadastroExpiraEm = null;

            await _context.SaveChangesAsync();

            return true;
        }

        public Task<bool> EmailExistenteAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
