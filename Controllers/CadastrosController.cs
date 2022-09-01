using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SistemaConsultas.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ILogger<CadastrosController> _logger;

        public CadastrosController(ILogger<CadastrosController> logger)
        {
            _logger = logger;
        }

       

        public IActionResult cadastroPaciente()
        {
            return View();
        }

        public IActionResult cadastroProfissional()
        {
            return View();
        }



        
    }
}