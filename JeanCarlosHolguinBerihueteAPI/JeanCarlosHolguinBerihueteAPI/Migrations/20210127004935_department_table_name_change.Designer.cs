﻿// <auto-generated />
using System;
using JeanCarlosHolguinBerihueteAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JeanCarlosHolguinBerihueteAPI.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20210127004935_department_table_name_change")]
    partial class department_table_name_change
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("JeanCarlosHolguinBerihueteAPI.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("JeanCarlosHolguinBerihueteAPI.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("Document")
                        .HasColumnType("int");

                    b.Property<bool>("Genre")
                        .HasColumnType("bit");

                    b.Property<string>("Names")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surnames")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("JeanCarlosHolguinBerihueteAPI.Models.User", b =>
                {
                    b.HasOne("JeanCarlosHolguinBerihueteAPI.Models.Department", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("JeanCarlosHolguinBerihueteAPI.Models.Department", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}