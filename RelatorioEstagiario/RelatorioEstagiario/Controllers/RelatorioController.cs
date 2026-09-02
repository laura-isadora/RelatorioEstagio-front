using Microsoft.AspNetCore.Mvc;
using RelatorioEstagiario.Models;
using RelatorioEstagiario.Services;

namespace RelatorioEstagiario.Controllers;

public class RelatorioController : Controller
{
    private readonly IRelatorioService _service;

    public RelatorioController(IRelatorioService service)
    {
        _service = service;
    }

    // GET: /Relatorio/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Relatorio/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(RelatorioEstagio relatorio)
    {
        if (!ModelState.IsValid)
        {
            return View(relatorio);
        }

        await _service.CriarAsync(relatorio);

        return RedirectToAction(nameof(Sucesso));
    }

    // GET: /Relatorio/Sucesso
    [HttpGet]
    public IActionResult Sucesso()
    {
        return View();
    }
}
