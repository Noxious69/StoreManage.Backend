﻿// <auto-generated />
using Inventory.Infrastructore.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory.Infrastructore.Migrations
{
    [DbContext(typeof(InventoryDB))]
    partial class InventoryDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inventory.Core.Entities.Order", b =>
                {
                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BoxCount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BoxType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Edge")
                        .HasColumnType("bit");

                    b.Property<bool>("Lable")
                        .HasColumnType("bit");

                    b.Property<string>("OrderColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderCount")
                        .HasColumnType("int");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoColor")
                        .HasColumnType("bit");

                    b.HasKey("CustomerName");

                    b.ToTable("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
