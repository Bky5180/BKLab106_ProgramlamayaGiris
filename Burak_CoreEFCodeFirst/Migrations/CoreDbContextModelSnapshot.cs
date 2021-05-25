﻿// <auto-generated />
using System;
using Burak_CoreEntityCodeFirst.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Burak_CoreEntityCodeFirst.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    partial class CoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUser", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUserContactDetails", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserContactDetails");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUserLoginDetails", b =>
                {
                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("UserLoginDetails");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.EmployeeContactDetail", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("integer");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("StudentName")
                        .HasColumnType("text");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseID")
                        .HasColumnType("integer");

                    b.Property<int>("StudentsStudentID")
                        .HasColumnType("integer");

                    b.HasKey("CoursesCourseID", "StudentsStudentID");

                    b.HasIndex("StudentsStudentID");

                    b.ToTable("CoursesStudents");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUserContactDetails", b =>
                {
                    b.HasOne("CoreEntityCodeFirst.Entity.AppUser", "User")
                        .WithOne("ContactDetails")
                        .HasForeignKey("CoreEntityCodeFirst.Entity.AppUserContactDetails", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUserLoginDetails", b =>
                {
                    b.HasOne("CoreEntityCodeFirst.Entity.AppUser", "User")
                        .WithOne("LoginDetails")
                        .HasForeignKey("CoreEntityCodeFirst.Entity.AppUserLoginDetails", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.EmployeeContactDetail", b =>
                {
                    b.HasOne("CoreEntityCodeFirst.Entity.Employee", "Employee")
                        .WithOne("EmployeeContactDetail")
                        .HasForeignKey("CoreEntityCodeFirst.Entity.EmployeeContactDetail", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Product", b =>
                {
                    b.HasOne("CoreEntityCodeFirst.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("CoreEntityCodeFirst.Entity.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreEntityCodeFirst.Entity.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.AppUser", b =>
                {
                    b.Navigation("ContactDetails");

                    b.Navigation("LoginDetails");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CoreEntityCodeFirst.Entity.Employee", b =>
                {
                    b.Navigation("EmployeeContactDetail");
                });
#pragma warning restore 612, 618
        }
    }
}