﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaAPI.Data;

#nullable disable

namespace VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8021),
                            Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                            ImageUrl = "",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8068),
                            Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                            ImageUrl = "",
                            Name = "Premium Pool Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8071),
                            Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                            ImageUrl = "",
                            Name = "Luxury Pool Villa",
                            Occupancy = 4,
                            Rate = 400.0,
                            Sqft = 750,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8073),
                            Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                            ImageUrl = "",
                            Name = "Diamond Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8076),
                            Details = "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.",
                            ImageUrl = "",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}