﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApi.Db;

namespace MyWebApi.Migrations
{
    [DbContext(typeof(MyWebApiContext))]
    partial class MyWebApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyWebApi.Models.Good", b =>
                {
                    b.Property<Guid>("GoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("GoodId");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            GoodId = new Guid("142c9c42-d34e-4edd-b1ed-1958a5c25f73"),
                            Description = "New soccer ball",
                            Name = "Soccer ball",
                            Price = 111.0m
                        },
                        new
                        {
                            GoodId = new Guid("15ea14cd-6e9a-4666-87c2-e2d7ca75fc39"),
                            Description = "New foot ball",
                            Name = "Foot ball",
                            Price = 221.0m
                        });
                });

            modelBuilder.Entity("MyWebApi.Models.Pet", b =>
                {
                    b.Property<Guid>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("PetId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = new Guid("1abbd107-e590-4062-a170-7016630e91ac"),
                            Description = "Cute cat",
                            Name = "Cat",
                            Price = 111.0m
                        },
                        new
                        {
                            PetId = new Guid("d177e5be-9e00-41ba-98f1-ba21649ee745"),
                            Description = "Good boy",
                            Name = "Dog",
                            Price = 111.0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
