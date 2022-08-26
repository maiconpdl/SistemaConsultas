using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaConsultas.Models
{
    public class Profissional : Pessoa
    {
        
        public string? registro { get; set; }
        public string? especialidade { get; set; }

    }
}