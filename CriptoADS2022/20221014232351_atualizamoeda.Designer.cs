﻿// <auto-generated />
using System;
using CriptoADS2022.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CriptoADS2022.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221014232351_atualizamoeda")]
    partial class atualizamoeda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CriptoADS2022.Models.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cidade")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Conta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("clienteid")
                        .HasColumnType("int");

                    b.Property<int>("moedaid")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("clienteid");

                    b.HasIndex("moedaid");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Moeda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<float>("capital")
                        .HasColumnType("real");

                    b.Property<float>("compra")
                        .HasColumnType("real");

                    b.Property<string>("descricao")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("sigla")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<float>("var24h")
                        .HasColumnType("real");

                    b.Property<float>("var7d")
                        .HasColumnType("real");

                    b.Property<float>("venda")
                        .HasColumnType("real");

                    b.Property<float>("vol24")
                        .HasColumnType("real");

                    b.Property<float>("voltotal")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Moedas");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Transacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("contaid")
                        .HasColumnType("int");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.Property<int>("operacao")
                        .HasColumnType("int");

                    b.Property<float>("quantidade")
                        .HasColumnType("real");

                    b.Property<float>("valor")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.HasIndex("contaid");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Conta", b =>
                {
                    b.HasOne("CriptoADS2022.Models.Cliente", "cliente")
                        .WithMany("contas")
                        .HasForeignKey("clienteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CriptoADS2022.Models.Moeda", "moeda")
                        .WithMany("contas")
                        .HasForeignKey("moedaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");

                    b.Navigation("moeda");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Transacao", b =>
                {
                    b.HasOne("CriptoADS2022.Models.Conta", "conta")
                        .WithMany("transacoes")
                        .HasForeignKey("contaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("conta");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Cliente", b =>
                {
                    b.Navigation("contas");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Conta", b =>
                {
                    b.Navigation("transacoes");
                });

            modelBuilder.Entity("CriptoADS2022.Models.Moeda", b =>
                {
                    b.Navigation("contas");
                });
#pragma warning restore 612, 618
        }
    }
}
