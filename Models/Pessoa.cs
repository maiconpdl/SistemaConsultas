using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaConsultas.Models
{
    public class Pessoa
    {
        public int id { get; set; }
        public string? nome { get; set; }
        public string? dataNascimento { get; set; }
        public string? sexo { get; set; }
        public string? telefone { get; set; }
        public string? cpf { get; set; }
        public string? cep { get; set; }
        public string? estado { get; set; }
        public string? cidade { get; set; }
        public string? bairro { get; set; }
        public string? rua { get; set; }
        public string? numero { get; set; }
        
    }
}