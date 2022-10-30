using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;
using SistemaConsultas.Models;

namespace Projeto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Contexto _contexto;
    public static string mensagem = "";
    public HomeController(ILogger<HomeController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        

        ViewData["mensagem"] = mensagem;
        
        return View();
    }

    public async Task<IActionResult> validaUsuario(string usuario, string senha){
        List<Usuario> usuarios = await _contexto.usuarios.ToListAsync();
        if(ModelState.IsValid){
            foreach(var u in usuarios){
            if((u.login == usuario)&&(u.senha == senha)){
            
            
               
                //return View("Index");
                return RedirectToAction("Index", "Home");
                
                
            }
        }
        }
        mensagem = "Login ou senha incorretos!";
        return RedirectToAction("Login", "Home");
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
