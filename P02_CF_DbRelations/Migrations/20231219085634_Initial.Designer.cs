﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02_CF_DbRelations.Data;

#nullable disable

namespace P02_CF_DbRelations.Migrations
{
    [DbContext(typeof(CFDbRelationContext))]
    [Migration("20231219085634_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("P02_CF_DbRelations.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("PersonelsPersonelID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("PersonelsPersonelID");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"), 1L, 1);

                    b.Property<int>("CitiesCityID")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentsDepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("PersonelID");

                    b.HasIndex("CitiesCityID");

                    b.HasIndex("DepartmentsDepartmentID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoriesCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoriesCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Order", b =>
                {
                    b.HasOne("P02_CF_DbRelations.Models.Personel", "Personels")
                        .WithMany("Orders")
                        .HasForeignKey("PersonelsPersonelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_CF_DbRelations.Models.Product", "Products")
                        .WithMany("Orders")
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personels");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Personel", b =>
                {
                    b.HasOne("P02_CF_DbRelations.Models.City", "Cities")
                        .WithMany("Personels")
                        .HasForeignKey("CitiesCityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_CF_DbRelations.Models.Department", "Departments")
                        .WithMany("Personels")
                        .HasForeignKey("DepartmentsDepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Product", b =>
                {
                    b.HasOne("P02_CF_DbRelations.Models.Category", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoriesCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.City", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Department", b =>
                {
                    b.Navigation("Personels");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Personel", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("P02_CF_DbRelations.Models.Product", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
