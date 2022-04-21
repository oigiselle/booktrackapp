﻿// <auto-generated />
using System;
using BookTrack_Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackApp.Migrations
{
    [DbContext(typeof(RetailDbContext))]
    [Migration("20220421010354_First Migration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTrack_Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ISBN");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTrack_Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryId");

                    b.HasIndex("Type1");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("BookTrack_Models.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type");

                    b.ToTable("CategoriesType");
                });

            modelBuilder.Entity("BookTrack_Models.Book", b =>
                {
                    b.HasOne("BookTrack_Models.Category", "CategoryId")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId1");

                    b.Navigation("CategoryId");
                });

            modelBuilder.Entity("BookTrack_Models.Category", b =>
                {
                    b.HasOne("BookTrack_Models.CategoryType", "Type")
                        .WithMany("Category")
                        .HasForeignKey("Type1");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("BookTrack_Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookTrack_Models.CategoryType", b =>
                {
                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
