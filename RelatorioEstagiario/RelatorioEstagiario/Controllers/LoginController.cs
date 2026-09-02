using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RelatorioEstagiario.Models.Adm;
using RelatorioEstagiario.Services;
using System.Security.Claims;

namespace RelatorioEstagiario.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IEmailService _emailService;

        public LoginController(IUsuarioService usuarioService, IEmailService emailService)
        {
            _usuarioService = usuarioService;
            _emailService = emailService;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // LOGIN
        [HttpPost]
        public async Task<IActionResult> Entrar(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", loginModel);
            }

            var usuario = await _usuarioService.BuscarPorLoginAsync(
                loginModel.Usuario,
                loginModel.Senha
            );

            if (usuario == null)
            {
                TempData["MensagemErro"] =
                    "Usuário ou senha inválidos.";

                return View("Index", loginModel);
            }

            var claims = new List<Claim>
            {
                new Claim(
                    ClaimTypes.NameIdentifier,
                    usuario.Id.ToString()
                ),

                new Claim(
                    ClaimTypes.Role,
                    usuario.Perfil
                )
            };

            var identity = new ClaimsIdentity(
                claims,
                CookieAuthenticationDefaults.AuthenticationScheme
            );

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                principal
            );

            return RedirectToAction("Index", "Admin");
        }


        // GET: /Login/EsqueciSenha
        [HttpGet]
        public IActionResult EsqueciSenha()
        {
            return View();
        }


        // POST: /Login/EsqueciSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EsqueciSenha(
    EsqueciSenhaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var usuario = await _usuarioService
                .BuscarPorEmailAsync(model.Email);

            if (usuario == null)
            {
                // Não revelamos se o e-mail existe ou não.
                TempData["Mensagem"] =
                    "Se o e-mail estiver cadastrado, você receberá um link para redefinir sua senha.";

                return RedirectToAction(nameof(EsqueciSenha));
            }

            var token = await _usuarioService
                .GerarTokenRedefinicaoAsync(model.Email);

            if (token == null)
            {
                TempData["Mensagem"] =
                    "Se o e-mail estiver cadastrado, você receberá um link para redefinir sua senha.";

                return RedirectToAction(nameof(EsqueciSenha));
            }

            var link = Url.Action(
                "RedefinirSenha",
                "Login",
                new { token = token },
                Request.Scheme
            );

            var mensagem = $@"
        <h2>Redefinição de senha</h2>

        <p>
            Recebemos uma solicitação para redefinir a senha
            da sua conta administrativa.
        </p>

        <p>
            Clique no botão abaixo para criar uma nova senha:
        </p>

        <p>
            <a href=""{link}""
               style=""
                   display:inline-block;
                   padding:12px 20px;
                   background-color:#0d6efd;
                   color:white;
                   text-decoration:none;
                   border-radius:5px;
               "">
                Redefinir minha senha
            </a>
        </p>

        <p>
            Este link é válido por <strong>30 minutos</strong>.
        </p>

        <p>
            Se você não solicitou essa alteração, ignore este e-mail.
        </p>
    ";

            await _emailService.EnviarEmailAsync(
                usuario.Email,
                "Redefinição de senha - Relatório de Estágio",
                mensagem
            );

            TempData["Mensagem"] =
                "Se o e-mail estiver cadastrado, você receberá um link para redefinir sua senha.";

            return RedirectToAction(nameof(EsqueciSenha));
        }


        // GET: /Login/RedefinirSenha
        [HttpGet]
        public async Task<IActionResult> RedefinirSenha(
            string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return BadRequest("Token de redefinição inválido.");
            }

            var usuario = await _usuarioService
                .BuscarPorTokenAsync(token);

            if (usuario == null)
            {
                return BadRequest(
                    "O link de redefinição é inválido ou expirou."
                );
            }

            var model = new RedefinirSenhaModel
            {
                Token = token
            };

            return View(model);
        }


        // POST: /Login/RedefinirSenha
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RedefinirSenha(
            RedefinirSenhaModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var sucesso = await _usuarioService
                .RedefinirSenhaAsync(
                    model.Token,
                    model.NovaSenha
                );

            if (!sucesso)
            {
                ModelState.AddModelError(
                    string.Empty,
                    "O link de redefinição é inválido ou expirou."
                );

                return View(model);
            }

            TempData["Mensagem"] =
                "Sua senha foi redefinida com sucesso. Agora você pode fazer login.";

            return RedirectToAction(nameof(Index));
        }
    }
}
