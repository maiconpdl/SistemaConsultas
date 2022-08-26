using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaConsultas.Models
{
    public class Usuario : Pessoa
    {

        public string? login { get; set; }
        public string? senha { get; set; }        
    }
}