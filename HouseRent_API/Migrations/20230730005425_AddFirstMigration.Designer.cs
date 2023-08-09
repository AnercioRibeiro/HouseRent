﻿// <auto-generated />
using System;
using HouseRent_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HouseRent_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230730005425_AddFirstMigration")]
    partial class AddFirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HouseRent_API.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Elevator")
                        .HasColumnType("bit");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipalities")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PaymentPeriodicy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipology")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Publications");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Address = "Projecto Nova vida",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Apartamento T2",
                            Details = "2 quartos, 1 sala, 1 casa de banho, cozinha e dispensa",
                            Elevator = false,
                            Floor = "3º Andar",
                            Identifier = "1234",
                            ImageUrl = "",
                            Latitude = "-8.8303705",
                            Longitude = "13.2779031",
                            Municipalities = "Kilamba Kiaxi",
                            Name = "",
                            PaymentPeriodicy = "Mensal",
                            Price = 400000m,
                            Tipology = "T2",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}