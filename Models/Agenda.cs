using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaConsultas.Models
{
    public class Agenda
    {
        public string? especialidade { get; set; }
        public string? profissional { get; set; }
        public string? paciente { get; set; }
        public string? data { get; set; }
        public string? hora { get; set; }
      
    }
}