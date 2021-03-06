﻿// <auto-generated />
using System;
using Api_Teste.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Api_Teste.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20210129042948_inicial-3")]
    partial class inicial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Api_Teste.Models.Desenvolvedor", b =>
                {
                    b.Property<int>("DesenvolvedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesenvolvedorId");

                    b.ToTable("Desenvolvedor");
                });

            modelBuilder.Entity("Api_Teste.Models.DevProjeto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.Property<int>("ProjetoId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DevProjeto");
                });

            modelBuilder.Entity("Api_Teste.Models.Lancamento", b =>
                {
                    b.Property<int>("LancamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("DesenvolvedorId")
                        .HasColumnType("int");

                    b.HasKey("LancamentoId");

                    b.HasIndex("DesenvolvedorId");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("Api_Teste.Models.Projeto", b =>
                {
                    b.Property<int>("ProjetoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjetoId");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("Api_Teste.Models.Lancamento", b =>
                {
                    b.HasOne("Api_Teste.Models.Desenvolvedor", "Desenvolvedor")
                        .WithMany()
                        .HasForeignKey("DesenvolvedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Desenvolvedor");
                });
#pragma warning restore 612, 618
        }
    }
}
