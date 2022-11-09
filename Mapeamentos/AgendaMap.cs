using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaConsultas.Models;

namespace SistemaConsultas.Mapeamentos
{
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.HasKey(a => a.id);
            builder.Property(a => a.profissional).IsRequired();
            builder.Property(a => a.paciente).IsRequired();
            builder.Property(a => a.especialidade).IsRequired();
            builder.Property(a => a.data).IsRequired();
            builder.Property(a => a.hora).IsRequired();
        }
    }
}