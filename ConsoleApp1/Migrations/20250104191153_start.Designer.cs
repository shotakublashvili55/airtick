﻿// <auto-generated />
using System;
using ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250104191153_start")]
    partial class start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConsoleApp1.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("capacityBuisness")
                        .HasColumnType("int");

                    b.Property<int>("capacitySecondEconom")
                        .HasColumnType("int");

                    b.Property<int>("manufactureYear")
                        .HasColumnType("int");

                    b.Property<string>("regNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("aircraft");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HostAirport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("color2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("airline");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Boarding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PassengerId")
                        .HasColumnType("bit");

                    b.Property<string>("RouteNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeatNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Window")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("boarding");
                });

            modelBuilder.Entity("ConsoleApp1.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ArrivalFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DepartureFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("city");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Flights", b =>
                {
                    b.Property<string>("RouteNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AircraftRegNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CancellationBefore")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("DepartureTime")
                        .HasColumnType("time");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("Food")
                        .HasColumnType("bit");

                    b.Property<string>("FromCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FromHostCity")
                        .HasColumnType("bit");

                    b.Property<decimal>("PriceBaggage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceBuiAdult")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceBuiChild")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceEcoAdult")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceEcoChild")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ToCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RouteNo");

                    b.ToTable("flights");
                });

            modelBuilder.Entity("ConsoleApp1.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("passenger");
                });
#pragma warning restore 612, 618
        }
    }
}
