﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoyalBureauShipping.Models;

#nullable disable

namespace RoyalBureauShipping.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230617193044_AddDataUsers")]
    partial class AddDataUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RoyalBureauShipping.Models.CargoShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CargoShips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bulk Carrier"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Oil Tanker"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chemical Tanker"
                        },
                        new
                        {
                            Id = 4,
                            Name = " Gas Carrier"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cargo Ship other than any of the above"
                        });
                });

            modelBuilder.Entity("RoyalBureauShipping.Models.ShipModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Breadth")
                        .HasColumnType("int");

                    b.Property<int>("CargoShipId")
                        .HasColumnType("int");

                    b.Property<string>("Class_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<string>("GRT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IMO_NO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Leangh")
                        .HasColumnType("int");

                    b.Property<string>("Port_Of_Register")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Propulsion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VesselName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CargoShipId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("RoyalBureauShipping.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "RoyalBureauShipping@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "123456789"
                        });
                });

            modelBuilder.Entity("RoyalBureauShipping.Models.ShipModel", b =>
                {
                    b.HasOne("RoyalBureauShipping.Models.CargoShip", "CargoShip")
                        .WithMany()
                        .HasForeignKey("CargoShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CargoShip");
                });
#pragma warning restore 612, 618
        }
    }
}
