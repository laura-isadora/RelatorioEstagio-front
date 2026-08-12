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

    // GET Relatorio
    public async Task<IActionResult> Index()
    {
        var relatorios = await _service.ListAsync();

        return View(relatorios);
    }

    // GET Relatorio/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST Relatorio/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(RelatorioEstagio relatorio)
    {
        if (!ModelState.IsValid)
        {
            return View(relatorio);
        }

        await _service.CriarAsync(relatorio);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var relatorio = await _service.BuscarAsync(id);

        if (relatorio == null)
        {
            return NotFound();
        }

        return View(relatorio);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var relatorio = await _service.BuscarAsync(id);

        if (relatorio == null)
        {
            return NotFound();
        }

        return View(relatorio);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
    int id,
    RelatorioEstagio relatorio)
    {
        if (id != relatorio.Id)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return View(relatorio);
        }

        var existente = await _service.BuscarAsync(id);

        if (existente == null)
        {
            return NotFound();
        }

        await _service.AtualizarAsync(relatorio);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var relatorio = await _service.BuscarAsync(id);

        if (relatorio == null)
        {
            return NotFound();
        }

        return View(relatorio);
    }

    [HttpPost]
    [ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeletePost(int id)
    {
        var relatorio = await _service.BuscarAsync(id);

        if (relatorio == null)
        {
            return NotFound();
        }

        await _service.ExcluirAsync(id);

        return RedirectToAction(nameof(Index));
    }
}
