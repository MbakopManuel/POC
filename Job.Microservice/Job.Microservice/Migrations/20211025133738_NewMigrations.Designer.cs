﻿// <auto-generated />
using System;
using Job.Microservice.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Job.Microservice.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211025133738_NewMigrations")]
    partial class NewMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Job.Microservice.Repositories.Job.DtoModels.JobDtoModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CreatedAt")
                        .HasColumnType("int");

                    b.Property<int?>("DeletedAt")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedAt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Job.Microservice.Repositories.Request.DtoModels.RequestDtoModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CreatedAt")
                        .HasColumnType("int");

                    b.Property<int?>("DeletedAt")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("UpdatedAt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("Job.Microservice.Repositories.Response.DtoModels.ResponseDtoModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CreatedAt")
                        .HasColumnType("int");

                    b.Property<int?>("DeletedAt")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RequestId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedAt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
