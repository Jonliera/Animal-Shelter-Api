﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    [Migration("20230211154440_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("Friendly")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 2,
                            Friendly = true,
                            Name = "Spencer",
                            Sex = "Male",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 1,
                            Friendly = false,
                            Name = "Max",
                            Sex = "Male",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 4,
                            Friendly = true,
                            Name = "Marlowe",
                            Sex = "Female",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 5,
                            Friendly = false,
                            Name = "Bubba",
                            Sex = "Male",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 3,
                            Friendly = true,
                            Name = "Charlie",
                            Sex = "Male",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 7,
                            Friendly = true,
                            Name = "Sammy",
                            Sex = "Male",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 9,
                            Friendly = false,
                            Name = "Mango",
                            Sex = "Female",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 3,
                            Friendly = true,
                            Name = "Jewel",
                            Sex = "Female",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 7,
                            Friendly = true,
                            Name = "Bobby",
                            Sex = "Male",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
