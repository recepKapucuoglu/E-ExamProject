﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ExamProjectContext))]
    [Migration("20221021161909_m4")]
    partial class m4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Concrete.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Point")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("Entities.Concrete.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsTrue")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("Entities.Concrete.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionCategoryId");

                    b.HasIndex("QuestionTypeId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Entities.Concrete.QuestionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("QuestionCategories");
                });

            modelBuilder.Entity("Entities.Concrete.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlınanPuan")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslangıçTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("BaşarılıMı")
                        .HasColumnType("bit");

                    b.Property<DateTime>("BitişTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Entities.Concrete.UserExam", b =>
                {
                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ExamId");

                    b.HasIndex("ExamId");

                    b.ToTable("UserExam");
                });

            modelBuilder.Entity("Entities.Concrete.Exam", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Exams")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Entities.Concrete.Option", b =>
                {
                    b.HasOne("Entities.Concrete.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Entities.Concrete.Question", b =>
                {
                    b.HasOne("Entities.Concrete.QuestionCategory", "QuestionCategory")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionCategoryId");

                    b.HasOne("Entities.Concrete.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeId");
                });

            modelBuilder.Entity("Entities.Concrete.QuestionCategory", b =>
                {
                    b.HasOne("Entities.Concrete.Exam", "Exam")
                        .WithMany("QuestionCategories")
                        .HasForeignKey("ExamId");
                });

            modelBuilder.Entity("Entities.Concrete.UserExam", b =>
                {
                    b.HasOne("Entities.Concrete.Exam", "Exam")
                        .WithMany("Users")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Exams")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
