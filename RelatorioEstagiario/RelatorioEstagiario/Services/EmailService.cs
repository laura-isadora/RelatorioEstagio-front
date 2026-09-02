using System.Net;
using System.Net.Mail;

namespace RelatorioEstagiario.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task EnviarEmailAsync(string destinatario, string assunto, string mensagem)
        {
            var smtp = _configuration.GetSection("Email");

            var remetente = smtp["Remetente"];
            var senha = smtp["Senha"];
            var servidor = smtp["Servidor"];
            var porta = int.Parse(smtp["Porta"] ?? "587");

            using var mail = new MailMessage();

            mail.From = new MailAddress(remetente!);
            mail.To.Add(destinatario);
            mail.Subject = assunto;
            mail.Body = mensagem;
            mail.IsBodyHtml = true;

            using var client = new SmtpClient(servidor, porta);

            client.Credentials = new NetworkCredential(
                remetente,
                senha
            );

            client.EnableSsl = true;

            await client.SendMailAsync(mail);
        }
    }
}