using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto.Models;

namespace Projeto.Controllers;

public class UsuarioController : Controller
{
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
    }


    public IActionResult cadastroUsuario()
    {
        return View();
    }

    public async Task<IActionResult> salvarUsuario(){


        
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
