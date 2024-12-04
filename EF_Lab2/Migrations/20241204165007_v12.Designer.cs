﻿// <auto-generated />
using System;
using EF_Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_Lab2.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20241204165007_v12")]
    partial class v12
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_Lab2.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brief")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("JoinDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            JoinDate = new DateOnly(2012, 5, 1),
                            Name = "Ahmed Hassan",
                            Password = "123",
                            Username = "Ahmed Hassan"
                        },
                        new
                        {
                            Id = 2,
                            JoinDate = new DateOnly(2012, 5, 1),
                            Name = "Mona Mohamed",
                            Password = "123",
                            Username = "Mona Mohamed"
                        },
                        new
                        {
                            Id = 3,
                            JoinDate = new DateOnly(2012, 5, 1),
                            Name = "Mazen Mostafa",
                            Password = "123",
                            Username = "Mazen Mostafa"
                        });
                });

            modelBuilder.Entity("EF_Lab2.Models.Catalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Business",
                            Name = "Business"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Sports",
                            Name = "Sports"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Entertainment",
                            Name = "Entertainment"
                        });
                });

            modelBuilder.Entity("EF_Lab2.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brief")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("NewDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("auth_id")
                        .HasColumnType("int");

                    b.Property<int>("cat_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("auth_id");

                    b.HasIndex("cat_id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NewDateTime = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Mideast Stocks",
                            auth_id = 0,
                            cat_id = 0
                        },
                        new
                        {
                            Id = 2,
                            NewDateTime = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Liverpool News",
                            auth_id = 0,
                            cat_id = 0
                        },
                        new
                        {
                            Id = 3,
                            NewDateTime = new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Film23 Release",
                            auth_id = 0,
                            cat_id = 0
                        });
                });

            modelBuilder.Entity("EF_Lab2.Models.News", b =>
                {
                    b.HasOne("EF_Lab2.Models.Author", "author")
                        .WithMany("news")
                        .HasForeignKey("auth_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_Lab2.Models.Catalog", "catalog")
                        .WithMany("news")
                        .HasForeignKey("cat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("catalog");
                });

            modelBuilder.Entity("EF_Lab2.Models.Author", b =>
                {
                    b.Navigation("news");
                });

            modelBuilder.Entity("EF_Lab2.Models.Catalog", b =>
                {
                    b.Navigation("news");
                });
#pragma warning restore 612, 618
        }
    }
}
