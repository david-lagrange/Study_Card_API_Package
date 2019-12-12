﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using study_cards_api.Data;

namespace study_cards_api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("study_cards_api.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Definition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StackId")
                        .HasColumnType("int");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StackId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Definition = "JS object that holds values for a component",
                            StackId = 1,
                            Word = "state"
                        },
                        new
                        {
                            Id = 2,
                            Definition = "A way to pass data into components on initialization",
                            StackId = 1,
                            Word = "props"
                        },
                        new
                        {
                            Id = 3,
                            Definition = "Reusable building blocks for UI using JSX",
                            StackId = 1,
                            Word = "component"
                        },
                        new
                        {
                            Id = 4,
                            Definition = "Named space in memory",
                            StackId = 2,
                            Word = "variable"
                        },
                        new
                        {
                            Id = 5,
                            Definition = "Template for an object that consists of member variables, constructor, methods",
                            StackId = 2,
                            Word = "class"
                        },
                        new
                        {
                            Id = 6,
                            Definition = "Instance of a class",
                            StackId = 2,
                            Word = "object"
                        },
                        new
                        {
                            Id = 7,
                            Definition = "Reusable component in Flutter",
                            StackId = 3,
                            Word = "widget"
                        });
                });

            modelBuilder.Entity("study_cards_api.Models.Stack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "React"
                        },
                        new
                        {
                            Id = 2,
                            Title = "C#"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Flutter"
                        });
                });

            modelBuilder.Entity("study_cards_api.Models.Card", b =>
                {
                    b.HasOne("study_cards_api.Models.Stack", "Stack")
                        .WithMany()
                        .HasForeignKey("StackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
