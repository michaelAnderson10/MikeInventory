﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MikeInventory.Data;

#nullable disable

namespace MikeInventory.Migrations
{
    [DbContext(typeof(MikeInventoryContext))]
    [Migration("20230426101558_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MikeInventory.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<string>("PartDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartQuantity")
                        .HasColumnType("int");

                    b.Property<string>("PartTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PartId");

                    b.HasIndex("SupplierID");

                    b.HasIndex("UserID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("MikeInventory.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SupplierTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("MikeInventory.Models.Tool", b =>
                {
                    b.Property<int>("ToolId")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.Property<string>("ToolDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToolQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ToolTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ToolId");

                    b.HasIndex("SupplierID");

                    b.HasIndex("UserID");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("MikeInventory.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTag")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MikeInventory.Models.Part", b =>
                {
                    b.HasOne("MikeInventory.Models.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierID");

                    b.HasOne("MikeInventory.Models.User", "User")
                        .WithMany("Parts")
                        .HasForeignKey("UserID");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MikeInventory.Models.Tool", b =>
                {
                    b.HasOne("MikeInventory.Models.Supplier", "Supplier")
                        .WithMany("Tools")
                        .HasForeignKey("SupplierID");

                    b.HasOne("MikeInventory.Models.User", "User")
                        .WithMany("Tools")
                        .HasForeignKey("UserID");

                    b.Navigation("Supplier");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MikeInventory.Models.Supplier", b =>
                {
                    b.Navigation("Parts");

                    b.Navigation("Tools");
                });

            modelBuilder.Entity("MikeInventory.Models.User", b =>
                {
                    b.Navigation("Parts");

                    b.Navigation("Tools");
                });
#pragma warning restore 612, 618
        }
    }
}
