﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SGLOC.Infrastructure.Data;
using System;

namespace SGLOC.Infrastructure.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20180421030401_ConfiguraClassesClienteEnderecoLocacaoMarcaVeiculo")]
    partial class ConfiguraClassesClienteEnderecoLocacaoMarcaVeiculo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Locacao", b =>
                {
                    b.Property<int>("LocacaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime>("DataLocacao");

                    b.Property<int>("Numero")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("VeiculoId");

                    b.HasKey("LocacaoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("MarcaId");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("VeiculoId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("SGLOC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Endereco")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Locacao", b =>
                {
                    b.HasOne("SGLOC.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGLOC.ApplicationCore.Entity.Veiculo", "Veiculo")
                        .WithMany("Locacoes")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SGLOC.ApplicationCore.Entity.Veiculo", b =>
                {
                    b.HasOne("SGLOC.ApplicationCore.Entity.Marca", "Marca")
                        .WithMany("Veiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}