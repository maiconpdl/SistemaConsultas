using Microsoft.AspNetCore.Mvc;
using SistemaConsultas.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaConsultas.Controllers
{
    [Route("[controller]")]
    public class AgendaController : Controller
    {
        private readonly ILogger<AgendaController> _logger;
        private readonly Contexto _contexto;

        public AgendaController(ILogger<AgendaController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        [HttpGet("agendar")]
        public async Task<IActionResult> Agenda()
        {
            Agenda agenda = new Agenda();
            agenda.profissionais = await _contexto.profissionais.ToListAsync();
            agenda.pacientes = await _contexto.pacientes.ToListAsync();
            return View(agenda);
        }

        [HttpPost]
        public async Task<IActionResult> salvarAgendamento(Agenda agenda)
        {
            if(ModelState.IsValid){
                await _contexto.agendamentos.AddRangeAsync(agenda);
                await _contexto.SaveChangesAsync();

                return RedirectToAction("Agenda");
            }    

            return RedirectToAction("Agenda");
        }

        [HttpGet("atender")]
        public async Task<IActionResult> Atendimento()
        {
            
            return View(await _contexto.agendamentos.ToListAsync());
        }


        
    }
}