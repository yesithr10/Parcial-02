﻿// <auto-generated />
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.Pago", b =>
                {
                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TerceroCedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TipoPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.Property<float>("ValorIva")
                        .HasColumnType("real");

                    b.HasKey("Codigo");

                    b.HasIndex("TerceroCedula");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Entidad.Tercero", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.ToTable("Terceros");
                });

            modelBuilder.Entity("Entidad.Pago", b =>
                {
                    b.HasOne("Entidad.Tercero", null)
                        .WithMany("Pagos")
                        .HasForeignKey("TerceroCedula");
                });
#pragma warning restore 612, 618
        }
    }
}
