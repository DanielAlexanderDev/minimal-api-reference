﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using entity_first_project;

#nullable disable

namespace entity_first_project.Migrations
{
    [DbContext(typeof(PrestamosContext))]
    partial class PrestamosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("entity_first_project.Models.Empleado", b =>
                {
                    b.Property<Guid>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<long>("Identificacion")
                        .HasMaxLength(10)
                        .HasColumnType("bigint");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Puesto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleado", (string)null);

                    b.HasData(
                        new
                        {
                            EmpleadoId = new Guid("7fe94fa9-9416-42a4-8e08-948a26d87266"),
                            Apellido = "LLumiquinga",
                            Identificacion = 1751631530L,
                            Nombre = "Daniel",
                            Puesto = "Desarrollador"
                        });
                });

            modelBuilder.Entity("entity_first_project.Models.Prestamo", b =>
                {
                    b.Property<long>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("PrestamoId"));

                    b.Property<long>("EmpleadoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("NumeroCuotas")
                        .HasColumnType("integer");

                    b.Property<double>("ValorCuotaMensual")
                        .HasColumnType("double precision");

                    b.Property<int>("ValorPrestamo")
                        .HasColumnType("integer");

                    b.HasKey("PrestamoId");

                    b.ToTable("Prestamo", (string)null);

                    b.HasData(
                        new
                        {
                            PrestamoId = 1L,
                            EmpleadoId = 1751631530L,
                            FechaCreacion = new DateTime(2023, 5, 30, 2, 26, 44, 18, DateTimeKind.Utc).AddTicks(4170),
                            NumeroCuotas = 3,
                            ValorCuotaMensual = 326.25,
                            ValorPrestamo = 1500
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
