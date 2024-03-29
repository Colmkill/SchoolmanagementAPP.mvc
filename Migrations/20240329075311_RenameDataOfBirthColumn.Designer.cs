﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolmanagementAPP.mvc.Data;

#nullable disable

namespace SchoolmanagementAPP.mvc.Migrations
{
    [DbContext(typeof(SchoolManagementDbContext))]
    [Migration("20240329075311_RenameDataOfBirthColumn")]
    partial class RenameDataOfBirthColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolmanagementAPP.mvc.Data.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Courses__3214EC07FB10CD46");

                    b.HasIndex(new[] { "Code" }, "UQ__Courses__A25C5AA727B7695D")
                        .IsUnique()
                        .HasFilter("[Code] IS NOT NULL");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolmanagementAPP.mvc.Data.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Lecturer__3214EC0747E6A014");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("SchoolmanagementAPP.mvc.Data.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Students__3214EC072D31CC5D");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
