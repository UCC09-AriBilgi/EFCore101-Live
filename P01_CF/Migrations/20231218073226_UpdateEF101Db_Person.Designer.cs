﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P01_CF.Data;

#nullable disable

namespace P01_CF.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20231218073226_UpdateEF101Db_Person")]
    partial class UpdateEF101Db_Person
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("P01_CF.Entities.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StandardId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StandardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("P01_CF.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<DateTime>("SDoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("SFName")
                        .IsRequired()
                        .HasColumnType("NVarchar(20)");

                    b.Property<string>("SLastName")
                        .IsRequired()
                        .HasColumnType("NVarchar(30)");

                    b.Property<int>("StandardId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("StandardId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("P01_CF.Entities.Student", b =>
                {
                    b.HasOne("P01_CF.Entities.Standard", "Standard")
                        .WithMany("Students")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Standard");
                });

            modelBuilder.Entity("P01_CF.Entities.Standard", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
