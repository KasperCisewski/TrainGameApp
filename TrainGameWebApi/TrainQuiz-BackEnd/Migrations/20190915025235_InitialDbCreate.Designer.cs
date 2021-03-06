﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainQuiz_BackEnd.Data.Context;

namespace TrainQuiz_BackEnd.Migrations
{
    [DbContext(typeof(TrainsQuizContext))]
    [Migration("20190915025235_InitialDbCreate")]
    partial class InitialDbCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerValue");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsCorrect");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Point", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("NumberOfPoints");

                    b.Property<int>("RouteId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.HasIndex("UserId");

                    b.ToTable("Point");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("QuestionValue");

                    b.Property<int>("SectionId");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("RouteStartSectionId");

                    b.Property<int>("TrainId");

                    b.HasKey("Id");

                    b.HasIndex("TrainId")
                        .IsUnique();

                    b.ToTable("Route");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("SectionCityA");

                    b.Property<string>("SectionCityB");

                    b.Property<int>("SectionDistance");

                    b.HasKey("Id");

                    b.ToTable("Section");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.SectionRoute", b =>
                {
                    b.Property<int>("SectionId");

                    b.Property<int>("RouteId");

                    b.HasKey("SectionId", "RouteId");

                    b.HasIndex("RouteId");

                    b.ToTable("SectionRoute");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("TicketEndSection");

                    b.Property<int>("TicketStartSection");

                    b.Property<int>("TrainId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("QuantityOfCarriages");

                    b.Property<string>("RouteId");

                    b.Property<string>("TrainName");

                    b.HasKey("Id");

                    b.ToTable("Train");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("NickName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Answer", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Question", "Question")
                        .WithMany("AnswerList")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Point", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Question", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Route", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Train", "Train")
                        .WithOne("Route")
                        .HasForeignKey("TrainQuiz_BackEnd.Data.Entities.Route", "TrainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.SectionRoute", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Route", "Route")
                        .WithMany("SectionRoutes")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Section", "Section")
                        .WithMany("SectionRoutes")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TrainQuiz_BackEnd.Data.Entities.Ticket", b =>
                {
                    b.HasOne("TrainQuiz_BackEnd.Data.Entities.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
