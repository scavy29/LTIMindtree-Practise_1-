﻿// <auto-generated />
using System;
using GRT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GRT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231110131736_Initial Migrations")]
    partial class InitialMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GRT.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventSpaceSpaceId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.Property<int>("SpaceId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeSlot")
                        .HasColumnType("time");

                    b.HasKey("BookingId");

                    b.HasIndex("EventSpaceSpaceId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("GRT.Models.EventSpace", b =>
                {
                    b.Property<int>("SpaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpaceId"));

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.HasKey("SpaceId");

                    b.ToTable("EventSpaces");
                });

            modelBuilder.Entity("GRT.Models.Booking", b =>
                {
                    b.HasOne("GRT.Models.EventSpace", "EventSpace")
                        .WithMany("Bookings")
                        .HasForeignKey("EventSpaceSpaceId");

                    b.Navigation("EventSpace");
                });

            modelBuilder.Entity("GRT.Models.EventSpace", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
