using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SistemaConsultas.Controllers
{
    [Route("[controller]")]
    public class AgendaController : Controller
    {
        private readonly ILogger<AgendaController> _logger;

        public AgendaController(ILogger<AgendaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Agenda()
        {
            return View();
        }

        
    }
}