using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaConsultas.Models;

namespace SistemaConsultas.Mapeamentos
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.nome).IsRequired();
            builder.Property(p => p.dataNascimento).IsRequired();
            builder.Property(p => p.sexo).IsRequired();
            builder.Property(p => p.telefone).IsRequired();
            builder.Property(p => p.cpf).IsRequired();
            builder.Property(p => p.cep).IsRequired();
            builder.Property(p => p.estado).IsRequired();
            builder.Property(p => p.cidade).IsRequired();
            builder.Property(p => p.bairro).IsRequired();
            builder.Property(p => p.cep).IsRequired();
            builder.Property(p => p.rua).IsRequired();
            builder.Property(p => p.numero);
            
        }
    }
}