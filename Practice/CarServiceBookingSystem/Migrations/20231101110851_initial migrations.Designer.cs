﻿// <auto-generated />
using CarServiceBookingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarServiceBookingSystem.Migrations
{
    [DbContext(typeof(CarServiceDbContext))]
    [Migration("20231101110851_initial migrations")]
    partial class initialmigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarServiceBookingSystem.Models.CarService", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarVariant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complaint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("CarServices");
                });
#pragma warning restore 612, 618
        }
    }
}
