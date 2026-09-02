using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RelatorioEstagiario.Models;
using RelatorioEstagiario.Services;

namespace RelatorioEstagiario.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IRelatorioService _service;

    public AdminController(IRelatorioService service)
    {
        _service = service;
    }

    // GET: /Admin
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var relatorios = await _service.ListAsync();

        return View(relatorios);
    }

    // GET: /Admin/Details/5
    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        var relatorio = await _service.BuscarAsync(id);

        if (relatorio == null)
        {
            return NotFound();
        }

        return View(relatorio);
    }

    // GET: /Admin/Edit/5
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

    // POST: /Admin/Edit/5
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

    // GET: /Admin/Delete/5
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

    // POST: /Admin/DeletePost/5
    [HttpPost]
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

    // GET: /Admin/Sair
    [HttpGet]
    public async Task<IActionResult> Sair()
    {
        await HttpContext.SignOutAsync();

        return RedirectToAction("Index", "Login");
    }
}
