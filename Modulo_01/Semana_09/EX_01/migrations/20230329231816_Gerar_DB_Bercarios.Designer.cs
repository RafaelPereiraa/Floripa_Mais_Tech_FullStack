﻿// <auto-generated />
using System;
using EX_01;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EX_01.Migrations
{
    [DbContext(typeof(Bercario))]
    [Migration("20230329231816_Gerar_DB_Bercarios")]
    partial class Gerar_DB_Bercarios
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EX_01.models.Bebe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Mae")
                        .HasColumnType("int");

                    b.Property<int>("Id_Parto")
                        .HasColumnType("int");

                    b.Property<decimal>("Peso_Nascimento")
                        .HasColumnType("decimal(4,3)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Mae");

                    b.HasIndex("Id_Parto");

                    b.ToTable("Bebes");
                });

            modelBuilder.Entity("EX_01.models.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Maes");
                });

            modelBuilder.Entity("EX_01.models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("EX_01.models.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataParto")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("HorarioParto")
                        .HasColumnType("time");

                    b.Property<int>("Id_Medico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Medico");

                    b.ToTable("Partos");
                });

            modelBuilder.Entity("EX_01.models.Bebe", b =>
                {
                    b.HasOne("EX_01.models.Mae", "Mae")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Mae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EX_01.models.Parto", "Parto")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Parto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mae");

                    b.Navigation("Parto");
                });

            modelBuilder.Entity("EX_01.models.Parto", b =>
                {
                    b.HasOne("EX_01.models.Medico", "Medico")
                        .WithMany("Partos")
                        .HasForeignKey("Id_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });

            modelBuilder.Entity("EX_01.models.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("EX_01.models.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("EX_01.models.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}