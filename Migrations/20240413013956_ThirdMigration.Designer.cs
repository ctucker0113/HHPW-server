﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HHPW_server.Migrations
{
    [DbContext(typeof(HHPWDbContext))]
    [Migration("20240413013956_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HHPW_server.Models.Item", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("ID");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Pulverizing Pepperoni Pizza",
                            Price = 12.99m
                        },
                        new
                        {
                            ID = 2,
                            Name = "Spicy Buffalo Wings",
                            Price = 8.99m
                        },
                        new
                        {
                            ID = 3,
                            Name = "Classic Margherita Pizza",
                            Price = 10.99m
                        },
                        new
                        {
                            ID = 4,
                            Name = "BBQ Chicken Feast Pizza",
                            Price = 13.99m
                        },
                        new
                        {
                            ID = 5,
                            Name = "Garlic Parmesan Wings",
                            Price = 9.49m
                        });
                });

            modelBuilder.Entity("HHPW_server.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OrderTypeID")
                        .HasColumnType("integer");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("Tip")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Date = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hurlyburlygirlie@gmail.com",
                            IsClosed = false,
                            Name = "Gary's Order",
                            OrderTypeID = 1,
                            PhoneNumber = -9741,
                            Tip = 10.90m,
                            Total = 22.55m,
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            Date = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sarahsmail@example.com",
                            IsClosed = true,
                            Name = "Sarah's Family Feast",
                            OrderTypeID = 2,
                            PhoneNumber = -8717,
                            Tip = 5.00m,
                            Total = 35.20m,
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            Date = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.doe@example.com",
                            IsClosed = false,
                            Name = "John's Quick Lunch",
                            OrderTypeID = 1,
                            PhoneNumber = -1174,
                            Tip = 3.00m,
                            Total = 15.99m,
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            Date = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emily.party@example.com",
                            IsClosed = true,
                            Name = "Emily's Dinner Party",
                            OrderTypeID = 2,
                            PhoneNumber = -9142,
                            Tip = 8.00m,
                            Total = 48.75m,
                            UserID = 4
                        },
                        new
                        {
                            ID = 5,
                            Date = new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mike.games@example.com",
                            IsClosed = false,
                            Name = "Mike's Game Night",
                            OrderTypeID = 1,
                            PhoneNumber = -6495,
                            Tip = 6.00m,
                            Total = 30.40m,
                            UserID = 5
                        });
                });

            modelBuilder.Entity("HHPW_server.Models.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int>("ItemID")
                        .HasColumnType("integer");

                    b.Property<int>("OrderID")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ItemID = 1,
                            OrderID = 1,
                            Quantity = 2
                        },
                        new
                        {
                            ID = 2,
                            ItemID = 2,
                            OrderID = 1,
                            Quantity = 1
                        },
                        new
                        {
                            ID = 3,
                            ItemID = 3,
                            OrderID = 2,
                            Quantity = 3
                        },
                        new
                        {
                            ID = 4,
                            ItemID = 4,
                            OrderID = 2,
                            Quantity = 1
                        },
                        new
                        {
                            ID = 5,
                            ItemID = 5,
                            OrderID = 3,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("HHPW_server.Models.OrderType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("OrderTypes");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Phone"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Online"
                        },
                        new
                        {
                            ID = 3,
                            Name = "In Person"
                        });
                });

            modelBuilder.Entity("HHPW_server.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("UID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Harry Potter",
                            UID = "sampleName1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Albus Dumbledore",
                            UID = "sampleName2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
