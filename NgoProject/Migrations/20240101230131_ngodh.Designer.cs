﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NgoProject.Models;

#nullable disable

namespace NgoProject.Migrations
{
    [DbContext(typeof(NgoProjectContext))]
    [Migration("20240101230131_ngodh")]
    partial class ngodh
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NgoProject.Models.Aboutu", b =>
                {
                    b.Property<int>("AboutusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutusId"));

                    b.Property<string>("AboutusContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutusDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutusImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutusId");

                    b.ToTable("Aboutus");
                });

            modelBuilder.Entity("NgoProject.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("NgoProject.Models.Banner", b =>
                {
                    b.Property<int>("IdOne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOne"));

                    b.Property<string>("ContentOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleOne")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOne");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("NgoProject.Models.Bannerss", b =>
                {
                    b.Property<int>("IdTwo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTwo"));

                    b.Property<string>("ContentTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTwo");

                    b.ToTable("Bannersses");
                });

            modelBuilder.Entity("NgoProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NgoProject.Models.Donate", b =>
                {
                    b.Property<int>("DonateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonateId"));

                    b.Property<DateTime?>("DonateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DonateMoney")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NewsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DonateId");

                    b.HasIndex("NewsId");

                    b.HasIndex("UserId");

                    b.ToTable("Donates");
                });

            modelBuilder.Entity("NgoProject.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<string>("FeedbackEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeedbackSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FeedbackId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("NgoProject.Models.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("NewsContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OurpartnerId")
                        .HasColumnType("int");

                    b.HasKey("NewsId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OurpartnerId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("NgoProject.Models.Ourpartner", b =>
                {
                    b.Property<int>("OurpartnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OurpartnerId"));

                    b.Property<string>("OurpartnerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurpartnerAddressWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurpartnerLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurpartnerMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurpartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurpartnerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OurpartnerId");

                    b.ToTable("Ourpartners");
                });

            modelBuilder.Entity("NgoProject.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAvatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NgoProject.Models.Donate", b =>
                {
                    b.HasOne("NgoProject.Models.News", "News")
                        .WithMany("Donates")
                        .HasForeignKey("NewsId");

                    b.HasOne("NgoProject.Models.User", "User")
                        .WithMany("Donates")
                        .HasForeignKey("UserId");

                    b.Navigation("News");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NgoProject.Models.Feedback", b =>
                {
                    b.HasOne("NgoProject.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NgoProject.Models.News", b =>
                {
                    b.HasOne("NgoProject.Models.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryId");

                    b.HasOne("NgoProject.Models.Ourpartner", "Ourpartner")
                        .WithMany("News")
                        .HasForeignKey("OurpartnerId");

                    b.Navigation("Category");

                    b.Navigation("Ourpartner");
                });

            modelBuilder.Entity("NgoProject.Models.Category", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("NgoProject.Models.News", b =>
                {
                    b.Navigation("Donates");
                });

            modelBuilder.Entity("NgoProject.Models.Ourpartner", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("NgoProject.Models.User", b =>
                {
                    b.Navigation("Donates");

                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
