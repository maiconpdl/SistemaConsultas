using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using SistemaConsultas.Models;


namespace Projeto.Controllers;

public class UsuarioController : Controller
{
    private readonly ILogger<UsuarioController> _logger;
    private readonly Contexto _contexto;

    public UsuarioController(ILogger<UsuarioController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    public async Task<IActionResult> Usuarios()
    {
        return View(await _contexto.usuarios.ToListAsync());
    }

    public IActionResult cadastroUsuario()
    {
        return View();
    }

    public async Task<IActionResult> salvarUsuario(Usuario usuario){
          if(ModelState.IsValid){
            await _contexto.usuarios.AddAsync(usuario);
            await _contexto.SaveChangesAsync();
            return RedirectToAction("Usuarios");
          }
        
        
        return View(cadastroUsuario);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
