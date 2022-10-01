using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaConsultas.Models;

namespace SistemaConsultas.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);
            builder.Property(u => u.nome).IsRequired();
            builder.Property(u => u.dataNascimento).IsRequired();
            builder.Property(u => u.sexo).IsRequired();
            builder.Property(u => u.telefone).IsRequired();
            builder.Property(u => u.cpf).IsRequired();
            builder.Property(u => u.cep).IsRequired();
            builder.Property(u => u.estado).IsRequired();
            builder.Property(u => u.cidade).IsRequired();
            builder.Property(u => u.bairro).IsRequired();
            builder.Property(u => u.cep).IsRequired();
            builder.Property(u => u.rua).IsRequired();
            builder.Property(u => u.numero).IsRequired();
            builder.Property(u => u.login).IsRequired();
            builder.Property(u => u.senha).IsRequired();

        }
    }
}