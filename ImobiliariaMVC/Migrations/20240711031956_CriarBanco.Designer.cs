﻿// <auto-generated />
using System;
using ImobiliariaMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImobiliariaMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240711031956_CriarBanco")]
    partial class CriarBanco
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ImobiliariaMVC.Models.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ImovelId")
                        .HasColumnType("int");

                    b.Property<int>("LocatarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImovelId");

                    b.HasIndex("LocatarioId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Alugado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("DonoID")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DonoID");

                    b.ToTable("Imoveis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alugado = false,
                            DonoID = 2,
                            Endereco = "Rua da Esperança, 777",
                            Valor = 770.0
                        },
                        new
                        {
                            Id = 2,
                            Alugado = false,
                            DonoID = 2,
                            Endereco = "Rua das Palmeiras",
                            Valor = 2000.0
                        },
                        new
                        {
                            Id = 3,
                            Alugado = false,
                            DonoID = 1,
                            Endereco = "Rua das Jacarandas",
                            Valor = 1500.0
                        },
                        new
                        {
                            Id = 4,
                            Alugado = false,
                            DonoID = 1,
                            Endereco = "Rua dos Ipes, 249",
                            Valor = 850.0
                        });
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Locador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Atividade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Locadores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atividade = "Comerciante",
                            Cpf = "123.345.231-12",
                            Endereco = "Rua Japão, 312",
                            Identidade = "MG12312312",
                            Nome = "Joao Carlos",
                            Telefone = "38313555"
                        },
                        new
                        {
                            Id = 2,
                            Atividade = "Padeiro",
                            Cpf = "654.655.211-12",
                            Endereco = "Rua Adolfo Pierucetii, 655",
                            Identidade = "MG8923712",
                            Nome = "Marcos Castro",
                            Telefone = "988745454"
                        });
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Locatario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Atividade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Locatarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Atividade = "Mestre de Obra",
                            Cpf = "654.233.211-12",
                            Identidade = "MG4444442",
                            Nome = "Juca Tadeu",
                            Telefone = "988774455"
                        },
                        new
                        {
                            Id = 2,
                            Atividade = "Confuso",
                            Cpf = "122.233.211-12",
                            Identidade = "MG4324442",
                            Nome = "Confuso Sobrinho",
                            Telefone = "966335544"
                        },
                        new
                        {
                            Id = 3,
                            Atividade = "Influencer",
                            Cpf = "111.233.211-12",
                            Identidade = "MG5555552",
                            Nome = "Chico Moedas",
                            Telefone = "988552233"
                        });
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Aluguel", b =>
                {
                    b.HasOne("ImobiliariaMVC.Models.Imovel", "Imovel")
                        .WithMany()
                        .HasForeignKey("ImovelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImobiliariaMVC.Models.Locatario", "Locatario")
                        .WithMany()
                        .HasForeignKey("LocatarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Imovel");

                    b.Navigation("Locatario");
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Imovel", b =>
                {
                    b.HasOne("ImobiliariaMVC.Models.Locador", "Dono")
                        .WithMany("Imoveis")
                        .HasForeignKey("DonoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dono");
                });

            modelBuilder.Entity("ImobiliariaMVC.Models.Locador", b =>
                {
                    b.Navigation("Imoveis");
                });
#pragma warning restore 612, 618
        }
    }
}
