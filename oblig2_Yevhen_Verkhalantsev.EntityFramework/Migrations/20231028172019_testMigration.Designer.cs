﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using oblig2_Yevhen_Verkhalantsev.EntityFramework;

#nullable disable

namespace oblig2_Yevhen_Verkhalantsev.EntityFramework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231028172019_testMigration")]
    partial class testMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.BlogEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<long>("UserFk")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserFk");

                    b.ToTable("Blogs", (string)null);
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.CommentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("PostFk")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<long>("UserFk")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PostFk");

                    b.HasIndex("UserFk");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.PostEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BlogFk")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BlogFk");

                    b.ToTable("Posts", (string)null);
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.BlogEntity", b =>
                {
                    b.HasOne("oblig2_Yevhen_Verkhalantsev.Database.UserEntity", "User")
                        .WithMany("Blogs")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.CommentEntity", b =>
                {
                    b.HasOne("oblig2_Yevhen_Verkhalantsev.Database.PostEntity", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("oblig2_Yevhen_Verkhalantsev.Database.UserEntity", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.PostEntity", b =>
                {
                    b.HasOne("oblig2_Yevhen_Verkhalantsev.Database.BlogEntity", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.BlogEntity", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.PostEntity", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("oblig2_Yevhen_Verkhalantsev.Database.UserEntity", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
