﻿// <auto-generated />
using Academy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcademyProject.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20201024102217_Intial_migration")]
    partial class Intial_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy_Models.Student", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("academicYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            id = "1",
                            academicYear = "FirstYear",
                            dateOfBirth = "2020-12-3",
                            description = "First Year Student",
                            name = "John"
                        },
                        new
                        {
                            id = "2",
                            academicYear = "SecondYear",
                            dateOfBirth = "2020-12-3",
                            description = "Second Year Student",
                            name = "Sami"
                        },
                        new
                        {
                            id = "3",
                            academicYear = "ThirdYear",
                            dateOfBirth = "2020-12-2",
                            description = "Third Year Student",
                            name = "Ahmed"
                        },
                        new
                        {
                            id = "4",
                            academicYear = "FourthYear",
                            dateOfBirth = "2020-2-11",
                            description = "Fourth Year Student",
                            name = "Mostafa"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
