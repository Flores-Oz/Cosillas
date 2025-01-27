﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(BarContext))]
    [Migration("20241022224628_DBInit")]
    partial class DBInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Beer", b =>
                {
                    b.Property<int>("beerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("beerID"));

                    b.Property<int>("brandID")
                        .HasColumnType("int");

                    b.Property<string>("nameBeer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("beerID");

                    b.HasIndex("brandID");

                    b.ToTable("Beer", (string)null);
                });

            modelBuilder.Entity("DB.Brand", b =>
                {
                    b.Property<int>("brandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("brandID"));

                    b.Property<int?>("brandID1")
                        .HasColumnType("int");

                    b.Property<string>("nameBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("brandID");

                    b.HasIndex("brandID1");

                    b.ToTable("Brand", (string)null);
                });

            modelBuilder.Entity("DB.Beer", b =>
                {
                    b.HasOne("DB.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("brandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("DB.Brand", b =>
                {
                    b.HasOne("DB.Brand", null)
                        .WithMany("Brands")
                        .HasForeignKey("brandID1");
                });

            modelBuilder.Entity("DB.Brand", b =>
                {
                    b.Navigation("Brands");
                });
#pragma warning restore 612, 618
        }
    }
}
