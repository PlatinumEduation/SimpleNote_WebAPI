﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleNote_WebAPI.Infrastructure;

#nullable disable

namespace SimpleNote_WebAPI.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220902222515_seeding2")]
    partial class seeding2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.AttributiesEntity", b =>
                {
                    b.Property<int>("Attribute_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Attribute_Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Attribute_Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Attributies");

                    b.HasData(
                        new
                        {
                            Attribute_Id = 1,
                            Name = "first attributies"
                        });
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.NotesEntity", b =>
                {
                    b.Property<int>("Note_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Note_Id"), 1L, 1);

                    b.Property<int?>("Attribute_Id_FK")
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Project_ID_FK")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id_FK")
                        .HasColumnType("int");

                    b.HasKey("Note_Id");

                    b.HasIndex("Attribute_Id_FK");

                    b.HasIndex("Project_ID_FK");

                    b.HasIndex("User_Id_FK");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Note_Id = 1,
                            Completed = false,
                            Note = "first note",
                            User_Id_FK = 1
                        },
                        new
                        {
                            Note_Id = 2,
                            Completed = false,
                            Note = "second note",
                            Project_ID_FK = 1,
                            User_Id_FK = 1
                        },
                        new
                        {
                            Note_Id = 3,
                            Attribute_Id_FK = 1,
                            Completed = false,
                            Note = "third note",
                            User_Id_FK = 1
                        },
                        new
                        {
                            Note_Id = 4,
                            Attribute_Id_FK = 1,
                            Completed = false,
                            Note = "fourth note",
                            Project_ID_FK = 1,
                            User_Id_FK = 1
                        });
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.ProjectsEntity", b =>
                {
                    b.Property<int>("Project_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Project_Id"), 1L, 1);

                    b.Property<bool?>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Project_Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Project_Id = 1,
                            Completed = false,
                            Title = "first project"
                        });
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.UsersEntity", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"), 1L, 1);

                    b.Property<DateTime>("Creation_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Last_Login_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("User_Id");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_Id = 1,
                            Creation_Date = new DateTime(2022, 9, 2, 18, 25, 14, 999, DateTimeKind.Local).AddTicks(9306),
                            Last_Login_Date = new DateTime(2022, 9, 2, 18, 25, 14, 999, DateTimeKind.Local).AddTicks(9337),
                            Password = "firstPass",
                            UserName = "first userName"
                        },
                        new
                        {
                            User_Id = 2,
                            Creation_Date = new DateTime(2022, 9, 2, 18, 25, 14, 999, DateTimeKind.Local).AddTicks(9340),
                            Last_Login_Date = new DateTime(2022, 9, 2, 18, 25, 14, 999, DateTimeKind.Local).AddTicks(9341),
                            Password = "guess",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.NotesEntity", b =>
                {
                    b.HasOne("SimpleNote_WebAPI.Infrastructure.Entities.AttributiesEntity", "Attributies")
                        .WithMany("Notes")
                        .HasForeignKey("Attribute_Id_FK");

                    b.HasOne("SimpleNote_WebAPI.Infrastructure.Entities.ProjectsEntity", "Project")
                        .WithMany("Notes")
                        .HasForeignKey("Project_ID_FK");

                    b.HasOne("SimpleNote_WebAPI.Infrastructure.Entities.UsersEntity", "Users")
                        .WithMany("Notes")
                        .HasForeignKey("User_Id_FK");

                    b.Navigation("Attributies");

                    b.Navigation("Project");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.AttributiesEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.ProjectsEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("SimpleNote_WebAPI.Infrastructure.Entities.UsersEntity", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
