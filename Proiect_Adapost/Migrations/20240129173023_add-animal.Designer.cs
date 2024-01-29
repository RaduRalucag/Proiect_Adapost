﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Adapost.Data;

#nullable disable

namespace Proiect_Adapost.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240129173023_add-animal")]
    partial class addanimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Proiect_Adapost.Models.Adapost.Adapost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Locatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("OrasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Nume")
                        .IsUnique();

                    b.HasIndex("OrasId");

                    b.ToTable("Adaposts");
                });

            modelBuilder.Entity("Proiect_Adapost.Models.Animal.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Culoare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Animale");
                });

            modelBuilder.Entity("Proiect_Adapost.Models.Orase.Oras", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orase");
                });

            modelBuilder.Entity("Proiect_Adapost.Models.Adapost.Adapost", b =>
                {
                    b.HasOne("Proiect_Adapost.Models.Orase.Oras", "Oras")
                        .WithMany("Adaposts")
                        .HasForeignKey("OrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oras");
                });

            modelBuilder.Entity("Proiect_Adapost.Models.Orase.Oras", b =>
                {
                    b.Navigation("Adaposts");
                });
#pragma warning restore 612, 618
        }
    }
}
