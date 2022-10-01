using Microsoft.AspNetCore.Mvc;
using SistemaConsultas.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaConsultas.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ILogger<CadastrosController> _logger;
        private readonly Contexto _contexto;

        public CadastrosController(ILogger<CadastrosController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

       

        public IActionResult cadastroPaciente()
        {
            return View();
        }

        
        public async Task<IActionResult> Profissionais()
        {
            return View(await _contexto.profissionais.ToListAsync());
        }

        public async Task<IActionResult> Pacientes()
        {
            return View(await _contexto.pacientes.ToListAsync());
        }

        public IActionResult cadastroProfissional()
        {
            

            return View();
        }

        public async Task<IActionResult> salvarPaciente(Paciente paciente){
            if(ModelState.IsValid){
                await _contexto.pacientes.AddRangeAsync(paciente);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Pacientes");
            }
            return View();
        }

        public async Task<IActionResult> salvarProfissional(Profissional profissional){
            if(ModelState.IsValid){
                await _contexto.profissionais.AddAsync(profissional);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Profissionais");
            }

            return View();
        }



        
    }
}