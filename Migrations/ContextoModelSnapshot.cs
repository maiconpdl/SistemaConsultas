﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SistemaConsultas.Models;

#nullable disable

namespace Projeto.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SistemaConsultas.Models.Paciente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("pacientes");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Profissional", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("especialidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("registro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("profissionais");
                });

            modelBuilder.Entity("SistemaConsultas.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("bairro")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("dataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rua")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
