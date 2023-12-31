﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Models;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20231115183514_IntialCreate")]
    partial class IntialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("ProductsApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 30000m,
                            ProductName = "Iphone 14"
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = false,
                            Price = 40000m,
                            ProductName = "Iphone 15"
                        },
                        new
                        {
                            ProductId = 3,
                            IsActive = true,
                            Price = 50000m,
                            ProductName = "Iphone 16"
                        },
                        new
                        {
                            ProductId = 4,
                            IsActive = false,
                            Price = 60000m,
                            ProductName = "Iphone 17"
                        },
                        new
                        {
                            ProductId = 5,
                            IsActive = true,
                            Price = 70000m,
                            ProductName = "Iphone 18"
                        },
                        new
                        {
                            ProductId = 6,
                            IsActive = true,
                            Price = 80000m,
                            ProductName = "Iphone 19"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
