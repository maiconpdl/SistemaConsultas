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

        
        public async Task<IActionResult> Profissionais(string profissional)
        {
            if(profissional != null){
                return View(await _contexto.profissionais.Where(p => p.nome.Contains(profissional)).ToListAsync());
            }
            return View(await _contexto.profissionais.ToListAsync());
        }

        public async Task<IActionResult> Pacientes(string paciente)
        {
                Console.WriteLine(paciente);
            if(paciente != null){
                return View(await _contexto.pacientes.Where(p => p.nome.Contains(paciente)).ToListAsync());
            }
            return View(await _contexto.pacientes.ToListAsync());
        }

        public async Task<IActionResult> Especialidades()
        {
            return View(await _contexto.especialidades.ToListAsync());
        }

        public async Task<IActionResult> cadastroProfissional()
        {
            Profissional profissional = new Profissional();
            profissional.especialidades = await _contexto.especialidades.ToListAsync();

            return View(profissional);
        }

        public IActionResult cadastroEspecialidade()
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

        public async Task<IActionResult> excluirPaciente(int id){

            _contexto.Remove(_contexto.pacientes.Single(p => p.id == id));
            await _contexto.SaveChangesAsync();

            return RedirectToAction("Pacientes");
        }

        public async Task<IActionResult> salvarProfissional(Profissional profissional){
            if(ModelState.IsValid){
                await _contexto.profissionais.AddAsync(profissional);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Profissionais");
            }

            return View();
        }

        public async Task<IActionResult> excluirProfissional(int id){

            _contexto.Remove(_contexto.profissionais.Single(p => p.id == id));
            await _contexto.SaveChangesAsync();

            return RedirectToAction("Profissionais");
        }


        public async Task<IActionResult> salvarEspecialidade(Especialidade especialidade){
            if(ModelState.IsValid){
                await _contexto.especialidades.AddRangeAsync(especialidade);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Especialidades");
            }
            return View();
        }
        
      
    }
}