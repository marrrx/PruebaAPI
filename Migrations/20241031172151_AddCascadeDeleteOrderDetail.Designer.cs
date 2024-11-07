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
    [Migration("20241031172151_AddCascadeDeleteOrderDetail")]
    partial class AddCascadeDeleteOrderDetail
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
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000),
                            Name = "Protein"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000),
                            Name = "Creatine"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4000),
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
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980),
                            Status = "Pendiente"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980),
                            Status = "En proceso"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3980),
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
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020),
                            Description = "Xwxss",
                            Name = "Whey Protein",
                            Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4020),
                            Description = "Xwxss",
                            Name = "Creatine Monohydrate",
                            Price = 19.989999999999998
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(4030),
                            Description = "Xwxss",
                            Name = "Pre-Workout",
                            Price = 24.989999999999998
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
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3910),
                            Email = "example@example.com",
                            Name = "Usuario1",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 10, 31, 11, 21, 51, 118, DateTimeKind.Local).AddTicks(3920),
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
                        .OnDelete(DeleteBehavior.Cascade)
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
