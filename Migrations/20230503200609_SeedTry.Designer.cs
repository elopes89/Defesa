﻿// <auto-generated />
using System;
using DefesaExercicio.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DefesaExercicio.Migrations
{
    [DbContext(typeof(BercarioContext))]
    [Migration("20230503200609_SeedTry")]
    partial class SeedTry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DefesaExercicio.Model.Bebe", b =>
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
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Mae");

                    b.HasIndex("Id_Parto");

                    b.ToTable("Bebe", (string)null);
                });

            modelBuilder.Entity("DefesaExercicio.Model.Mae", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mae", (string)null);
                });

            modelBuilder.Entity("DefesaExercicio.Model.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("DefesaExercicio.Model.Parto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data_Parto")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horario_Parto")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Medico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Medico");

                    b.ToTable("Parto", (string)null);
                });

            modelBuilder.Entity("DefesaExercicio.Model.Bebe", b =>
                {
                    b.HasOne("DefesaExercicio.Model.Mae", "BebeMae")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Mae")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Bebe_Mae");

                    b.HasOne("DefesaExercicio.Model.Parto", "BebeParto")
                        .WithMany("Bebes")
                        .HasForeignKey("Id_Parto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Bebe_Parto");

                    b.Navigation("BebeMae");

                    b.Navigation("BebeParto");
                });

            modelBuilder.Entity("DefesaExercicio.Model.Parto", b =>
                {
                    b.HasOne("DefesaExercicio.Model.Medico", "PartoMedico")
                        .WithMany("Partos")
                        .HasForeignKey("Id_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Parto_Medico");

                    b.Navigation("PartoMedico");
                });

            modelBuilder.Entity("DefesaExercicio.Model.Mae", b =>
                {
                    b.Navigation("Bebes");
                });

            modelBuilder.Entity("DefesaExercicio.Model.Medico", b =>
                {
                    b.Navigation("Partos");
                });

            modelBuilder.Entity("DefesaExercicio.Model.Parto", b =>
                {
                    b.Navigation("Bebes");
                });
#pragma warning restore 612, 618
        }
    }
}
