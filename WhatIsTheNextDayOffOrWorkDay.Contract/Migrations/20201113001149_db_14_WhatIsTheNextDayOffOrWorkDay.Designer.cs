﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhatIsTheNextDayOffOrWorkDay.Repository.Context;

namespace WhatIsTheNextDayOffOrWorkDay.Repository.Migrations
{
    [DbContext(typeof(WhatIsTheNextDayOffOrWorkDayDbContext))]
    [Migration("20201113001149_db_14_WhatIsTheNextDayOffOrWorkDay")]
    partial class db_14_WhatIsTheNextDayOffOrWorkDay
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Escala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("VigenciaInicial")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Escalas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "@FILIPOSO CPTM-ESCALA (4-1-3-2)",
                            VigenciaInicial = new DateTime(2020, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<int>("EscalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EscalaId");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apelido = "@filiposo",
                            Email = "lord.filiposo@gmail.com",
                            EscalaId = 1
                        });
                });

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Sequencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EscalaId")
                        .HasColumnType("int");

                    b.Property<int>("Indicador")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EscalaId");

                    b.ToTable("Sequencias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EscalaId = 1,
                            Indicador = 0,
                            Numero = 1
                        },
                        new
                        {
                            Id = 2,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 2
                        },
                        new
                        {
                            Id = 3,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 3
                        },
                        new
                        {
                            Id = 4,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 4
                        },
                        new
                        {
                            Id = 5,
                            EscalaId = 1,
                            Indicador = 0,
                            Numero = 5
                        },
                        new
                        {
                            Id = 6,
                            EscalaId = 1,
                            Indicador = 0,
                            Numero = 6
                        },
                        new
                        {
                            Id = 7,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 7
                        },
                        new
                        {
                            Id = 8,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 8
                        },
                        new
                        {
                            Id = 9,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 9
                        },
                        new
                        {
                            Id = 10,
                            EscalaId = 1,
                            Indicador = 1,
                            Numero = 10
                        });
                });

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Pessoa", b =>
                {
                    b.HasOne("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Escala", "Escala")
                        .WithMany()
                        .HasForeignKey("EscalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escala");
                });

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Sequencia", b =>
                {
                    b.HasOne("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Escala", "Escala")
                        .WithMany("Sequencias")
                        .HasForeignKey("EscalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escala");
                });

            modelBuilder.Entity("WhatIsTheNextDayOffOrWorkDay.Domain.Entity.Escala", b =>
                {
                    b.Navigation("Sequencias");
                });
#pragma warning restore 612, 618
        }
    }
}