﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SearchGear.Models;

namespace SearchGear.Migrations
{
    [DbContext(typeof(SearchGearContext))]
    [Migration("20220906160154_SeedDataWithFamilyProp")]
    partial class SeedDataWithFamilyProp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SearchGear.Models.Gear", b =>
                {
                    b.Property<int>("GearId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Family")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Model")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("GearId");

                    b.ToTable("Gears");

                    b.HasData(
                        new
                        {
                            GearId = 1,
                            Brand = "Osprey",
                            Family = "Backpacks",
                            Model = "Aether 55",
                            Price = 219
                        },
                        new
                        {
                            GearId = 2,
                            Brand = "Arcteryx",
                            Family = "Outerwear",
                            Model = "Alpha SV",
                            Price = 599
                        },
                        new
                        {
                            GearId = 3,
                            Brand = "Leki",
                            Family = "Accessories",
                            Model = "Trekking Poles",
                            Price = 139
                        },
                        new
                        {
                            GearId = 4,
                            Brand = "MSR",
                            Family = "Cooking",
                            Model = "Pocket Rocket",
                            Price = 49
                        },
                        new
                        {
                            GearId = 5,
                            Brand = "Lowa",
                            Family = "Footwear",
                            Model = "Weisshorn",
                            Price = 499
                        });
                });
#pragma warning restore 612, 618
        }
    }
}