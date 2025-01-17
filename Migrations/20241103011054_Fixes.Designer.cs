﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebaAPI.db;

#nullable disable

namespace PruebaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241103011054_Fixes")]
    partial class Fixes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebaAPI.models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5090),
                            Name = "Protein"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5100),
                            Name = "Creatine"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5100),
                            Name = "Pre-Workout"
                        });
                });

            modelBuilder.Entity("PruebaAPI.models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PruebaAPI.models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PruebaAPI.models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070),
                            Status = "Pendiente"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070),
                            Status = "En proceso"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5070),
                            Status = "Completado"
                        });
                });

            modelBuilder.Entity("PruebaAPI.models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(2810),
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Name = "Incredible Cotton Chair",
                            Price = 240.31999999999999
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3230),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Licensed Steel Soap",
                            Price = 2.73
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3260),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Refined Fresh Hat",
                            Price = 695.03999999999996
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3280),
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Gorgeous Rubber Mouse",
                            Price = 508.85000000000002
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3300),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Refined Concrete Fish",
                            Price = 166.33000000000001
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3320),
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Name = "Unbranded Metal Pants",
                            Price = 330.74000000000001
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3340),
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Gorgeous Frozen Bike",
                            Price = 891.37
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3360),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Name = "Ergonomic Steel Pizza",
                            Price = 446.88999999999999
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3370),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Gorgeous Steel Cheese",
                            Price = 970.66999999999996
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 579, DateTimeKind.Local).AddTicks(3390),
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Incredible Concrete Salad",
                            Price = 156.58000000000001
                        });
                });

            modelBuilder.Entity("PruebaAPI.models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4520),
                            ProductId = 10,
                            Url = "https://picsum.photos/640/480/?image=608"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4850),
                            ProductId = 6,
                            Url = "https://picsum.photos/640/480/?image=97"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4860),
                            ProductId = 6,
                            Url = "https://picsum.photos/640/480/?image=939"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4870),
                            ProductId = 9,
                            Url = "https://picsum.photos/640/480/?image=400"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4880),
                            ProductId = 5,
                            Url = "https://picsum.photos/640/480/?image=349"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4880),
                            ProductId = 8,
                            Url = "https://picsum.photos/640/480/?image=653"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4890),
                            ProductId = 8,
                            Url = "https://picsum.photos/640/480/?image=417"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4900),
                            ProductId = 7,
                            Url = "https://picsum.photos/640/480/?image=34"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4900),
                            ProductId = 10,
                            Url = "https://picsum.photos/640/480/?image=735"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 580, DateTimeKind.Local).AddTicks(4910),
                            ProductId = 9,
                            Url = "https://picsum.photos/640/480/?image=776"
                        });
                });

            modelBuilder.Entity("PruebaAPI.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5000),
                            Email = "example@example.com",
                            Name = "Usuario1",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 2, 19, 10, 54, 577, DateTimeKind.Local).AddTicks(5000),
                            Email = "example1@example.com",
                            Name = "Usuario2",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("PruebaAPI.models.Order", b =>
                {
                    b.HasOne("PruebaAPI.models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaAPI.models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PruebaAPI.models.OrderDetail", b =>
                {
                    b.HasOne("PruebaAPI.models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PruebaAPI.models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PruebaAPI.models.Product", b =>
                {
                    b.HasOne("PruebaAPI.models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PruebaAPI.models.ProductImage", b =>
                {
                    b.HasOne("PruebaAPI.models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PruebaAPI.models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PruebaAPI.models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("PruebaAPI.models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PruebaAPI.models.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductImages");
                });

            modelBuilder.Entity("PruebaAPI.models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
