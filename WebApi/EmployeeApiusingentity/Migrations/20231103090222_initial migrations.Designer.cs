﻿// <auto-generated />
using EmployeeApiusingentity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeApiusingentity.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231103090222_initial migrations")]
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

            modelBuilder.Entity("EmployeeApiusingentity.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EmployeeApiusingentity.Models.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignationId"));

                    b.Property<string>("DesignationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("EmployeeApiusingentity.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeApiusingentity.Models.Employee", b =>
                {
                    b.HasOne("EmployeeApiusingentity.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeApiusingentity.Models.Designation", "Designation")
                        .WithMany("Employees")
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("EmployeeApiusingentity.Models.Designation", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
