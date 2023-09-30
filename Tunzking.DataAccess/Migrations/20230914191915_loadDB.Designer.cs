﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tunzking.DataAccess.Data;

#nullable disable

namespace Tunzking.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230914191915_loadDB")]
    partial class loadDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Tunzking.Models.ApplicationRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descreption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Tunzking.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Tunzking.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A T-shirt, or tee for short, is a style of fabric shirt named after the T shape of its body and sleeves. Traditionally, it has short sleeves and a round neckline, known as a crew neck, which lacks a collar. T-shirts are generally made of a stretchy, light, and inexpensive fabric and are easy to clean. The T-shirt evolved from undergarments used in the 19th century and, in the mid-20th century, transitioned from undergarment to general-use casual clothing.",
                            DisplayOrder = 1,
                            Name = "Shirt"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A shoe is an item of footwear intended to protect and comfort the human foot. Though the human foot can adapt to varied terrains and climate conditions, it is vulnerable, and shoes provide protection. Form was originally tied to function but over time shoes also became fashion items. Some shoes are worn as safety equipment, such as steel-toe boots, which are required footwear at industrial worksites.",
                            DisplayOrder = 2,
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Description = "In modern times, skirts are very commonly worn by women and girls. Some exceptions include the izaar, worn by many Muslim cultures, and the kilt, a traditional men's garment in Scotland, Ireland, and sometimes England. Fashion designers such as Jean Paul Gaultier, Vivienne Westwood, Kenzo and Marc Jacobs have also shown men's skirts. Transgressing social codes, Gaultier frequently introduces the skirt into his men's wear collections as a means of injecting novelty into male attire, most famously the sarong seen on David Beckham.",
                            DisplayOrder = 3,
                            Name = "Skirt"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Shorts are a garment worn over the pelvic area, circling the waist and splitting to cover the upper part of the legs, sometimes extending down to the knees but not covering the entire length of the leg. They are called \"shorts\" because they are a shortened version of trousers, which cover the entire leg, but not the foot. Shorts are typically worn in warm weather or in an environment where comfort and airflow are more important than the protection of the legs.",
                            DisplayOrder = 4,
                            Name = "Short"
                        });
                });

            modelBuilder.Entity("Tunzking.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("CurrentPrice")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Jordan",
                            CategoryId = 2,
                            CurrentPrice = 200.0,
                            Description = "When it comes to hoops, Jordan Brand has earned its global reputation as innovator and collaborator. This AJ XXXVIII honors the International Basketball Federation—the governing body for basketball worldwide. Like white light containing every possible color, the striking outer conceals an insole decorated with all the hues of the vibrant FIBA logo. Boldness, from the inside out.",
                            Gender = "Men",
                            ImageUrl = "",
                            Price = 400.0,
                            Title = "Air Jordan XXXVIII \"FIBA\""
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Gucci",
                            CategoryId = 1,
                            CurrentPrice = 250.0,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                            Gender = "Men",
                            ImageUrl = "",
                            Price = 500.0,
                            Title = "Check Collar Cotton Polo Shirt"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Gucci",
                            CategoryId = 2,
                            CurrentPrice = 700.0,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                            Gender = "Women",
                            ImageUrl = "",
                            Price = 900.0,
                            Title = "WOMEN'S GUCCI JORDAAN LOAFER"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Zara",
                            CategoryId = 3,
                            CurrentPrice = 250.0,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                            Gender = "Women",
                            ImageUrl = "",
                            Price = 800.0,
                            Title = "Slit denim skirt"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Nike",
                            CategoryId = 4,
                            CurrentPrice = 90.0,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                            Gender = "Men",
                            ImageUrl = "",
                            Price = 100.0,
                            Title = "YOGA TRAINING SHORTS"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Dolce",
                            CategoryId = 2,
                            CurrentPrice = 200.0,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce interdum mi dui, ac blandit neque tempor eu. Integer nec odio eu lectus porta feugiat. Etiam id feugiat nunc. In eget dictum nulla, vel ultrices sem. Etiam pulvinar nunc sit amet tortor fermentum rhoncus. Nulla facilisi. Integer convallis diam elit, at sodales massa convallis sed. Suspendisse ultricies diam in rhoncus porta. Praesent et ipsum lectus. Phasellus eu mattis ipsum. Vestibulum imperdiet vitae orci nec fringilla. Praesent tempor elit eu nisi egestas viverra. Suspendisse ut metus quis lacus suscipit semper.",
                            Gender = "Women",
                            ImageUrl = "",
                            Price = 820.0,
                            Title = "Mixed-materials Daymaster sneakers"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Tunzking.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Tunzking.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Tunzking.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Tunzking.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tunzking.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Tunzking.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tunzking.Models.Product", b =>
                {
                    b.HasOne("Tunzking.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
