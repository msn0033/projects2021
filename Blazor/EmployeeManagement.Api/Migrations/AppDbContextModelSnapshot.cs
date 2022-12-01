﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = "1",
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = "2",
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = "3",
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = "4",
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateOfBrith")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = "1",
                            DateOfBrith = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = "1",
                            Email = "David@pragimtech.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Hastings",
                            PhotoName = "john.png"
                        },
                        new
                        {
                            EmployeeId = "2",
                            DateOfBrith = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = "2",
                            Email = "Sam@pragimtech.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Galloway",
                            PhotoName = "sam.jpg"
                        },
                        new
                        {
                            EmployeeId = "3",
                            DateOfBrith = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = "3",
                            Email = "mary@pragimtech.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoName = "mary.png"
                        },
                        new
                        {
                            EmployeeId = "4",
                            DateOfBrith = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = "4",
                            Email = "sara@pragimtech.com",
                            FirstName = "Sara",
                            Gender = 1,
                            LastName = "Longway",
                            PhotoName = "sara.png"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
