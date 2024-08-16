﻿// <auto-generated />
using System;
using BlogPlatform.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogPlatform.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogPlatform.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("BlogPlatform.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("BlogPostCategory", b =>
                {
                    b.Property<int>("blogPostsId")
                        .HasColumnType("int");

                    b.Property<int>("categoriesId")
                        .HasColumnType("int");

                    b.HasKey("blogPostsId", "categoriesId");

                    b.HasIndex("categoriesId");

                    b.ToTable("BlogPostCategory");
                });

            modelBuilder.Entity("BlogPostTag", b =>
                {
                    b.Property<int>("blogPostsId")
                        .HasColumnType("int");

                    b.Property<int>("tagsId")
                        .HasColumnType("int");

                    b.HasKey("blogPostsId", "tagsId");

                    b.HasIndex("tagsId");

                    b.ToTable("BlogPostTag");
                });

            modelBuilder.Entity("BlogPostCategory", b =>
                {
                    b.HasOne("BlogPlatform.Models.BlogPost", null)
                        .WithMany()
                        .HasForeignKey("blogPostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogPlatform.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("categoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogPostTag", b =>
                {
                    b.HasOne("BlogPlatform.Models.BlogPost", null)
                        .WithMany()
                        .HasForeignKey("blogPostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogPlatform.Models.Tag", null)
                        .WithMany()
                        .HasForeignKey("tagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}