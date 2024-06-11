﻿// <auto-generated />
using System;
using ApiFilme.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFilme.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiFilme.Models.Agenda", b =>
                {
                    b.Property<int>("AgendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Anotacoes")
                        .HasColumnType("longtext");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("HoraConclusao")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly>("HoraInicio")
                        .HasColumnType("time(6)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("AgendaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("ApiFilme.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Anotacoes")
                        .HasColumnType("longtext");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Sessao", b =>
                {
                    b.Property<int?>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.HasKey("FilmeId", "CinemaId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Sessoes");
                });

            modelBuilder.Entity("ApiFilme.Models.HorasTrabalhadas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("ManhaTurnoFim")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly?>("ManhaTurnoInicio")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly?>("NoiteTurnoFim")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly?>("NoiteTurnoInicio")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly?>("TardeTurnoFim")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly?>("TardeTurnoInicio")
                        .HasColumnType("time(6)");

                    b.HasKey("Id");

                    b.ToTable("HorasTrabalhadas");
                });

            modelBuilder.Entity("ApiFilme.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeOnly>("TempoDeExecucao")
                        .HasColumnType("time(6)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ServicoId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("ApiFilme.Models.Agenda", b =>
                {
                    b.HasOne("ApiFilme.Models.Cliente", "Cliente")
                        .WithMany("Agendas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiFilme.Models.Servico", "Servico")
                        .WithMany("Agendas")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Cinema", b =>
                {
                    b.HasOne("ApiFilme.Models.Flmes.Endereco", "Endereco")
                        .WithOne("Cinema")
                        .HasForeignKey("ApiFilme.Models.Flmes.Cinema", "EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Sessao", b =>
                {
                    b.HasOne("ApiFilme.Models.Flmes.Cinema", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiFilme.Models.Flmes.Filme", "Filme")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("ApiFilme.Models.Cliente", b =>
                {
                    b.Navigation("Agendas");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Cinema", b =>
                {
                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Endereco", b =>
                {
                    b.Navigation("Cinema")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiFilme.Models.Flmes.Filme", b =>
                {
                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("ApiFilme.Models.Servico", b =>
                {
                    b.Navigation("Agendas");
                });
#pragma warning restore 612, 618
        }
    }
}
