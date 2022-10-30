using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaConsultas.Mapeamentos;

namespace SistemaConsultas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Profissional> profissionais {get; set;}
        public DbSet<Paciente> pacientes {get; set;}
        public DbSet<Agenda> agendamentos {get; set;}
        public DbSet<Especialidade> especialidades { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){

        }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new ProfissionalMap());
            builder.ApplyConfiguration(new PacienteMap());
            builder.ApplyConfiguration(new AgendaMap());
            builder.ApplyConfiguration(new EspecialidadeMap());

        }
    
    }
}