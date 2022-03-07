﻿// <auto-generated />
using System;
using Education.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Education.Persistence.Migrations
{
    [DbContext(typeof(EducationDbContext))]
    partial class EducationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Education.Domain.Course", b =>
                {
                    b.Property<Guid>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("66344d40-c88e-4c44-a6ef-2a07c161bbca"),
                            CreationDate = new DateTime(2022, 3, 6, 22, 22, 49, 676, DateTimeKind.Local).AddTicks(892),
                            Description = "C basico",
                            Precio = 56m,
                            PublicationDate = new DateTime(2024, 3, 6, 22, 22, 49, 677, DateTimeKind.Local).AddTicks(7856),
                            Title = "C title"
                        },
                        new
                        {
                            CourseId = new Guid("1cc49d88-b0c3-442c-a87e-a2b5e38ddfdc"),
                            CreationDate = new DateTime(2022, 3, 6, 22, 22, 49, 679, DateTimeKind.Local).AddTicks(9783),
                            Description = "C avanzado",
                            Precio = 80m,
                            PublicationDate = new DateTime(2024, 3, 6, 22, 22, 49, 679, DateTimeKind.Local).AddTicks(9839),
                            Title = "C title-avanzado"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
