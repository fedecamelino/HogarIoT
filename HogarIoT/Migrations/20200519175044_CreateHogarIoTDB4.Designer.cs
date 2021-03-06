﻿// <auto-generated />
using HogarIoT;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HogarIoT.Migrations
{
    [DbContext(typeof(HogarIoTContext))]
    [Migration("20200519175044_CreateHogarIoTDB4")]
    partial class CreateHogarIoTDB4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HogarIoT.Dispositivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dispositivos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Dispositivo");
                });

            modelBuilder.Entity("HogarIoT.AireAcondicionado", b =>
                {
                    b.HasBaseType("HogarIoT.Dispositivo");

                    b.Property<int>("Mode")
                        .HasColumnType("int");

                    b.Property<int>("temperatura")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("AireAcondicionado");
                });

            modelBuilder.Entity("HogarIoT.Camara", b =>
                {
                    b.HasBaseType("HogarIoT.Dispositivo");

                    b.Property<bool>("Grabar")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Camara");
                });

            modelBuilder.Entity("HogarIoT.Heladera", b =>
                {
                    b.HasBaseType("HogarIoT.Dispositivo");

                    b.Property<int>("TempFreezer")
                        .HasColumnType("int");

                    b.Property<int>("TempHeladera")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Heladera");
                });

            modelBuilder.Entity("HogarIoT.Luz", b =>
                {
                    b.HasBaseType("HogarIoT.Dispositivo");

                    b.Property<int>("Intensidad")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Luz");
                });
#pragma warning restore 612, 618
        }
    }
}
