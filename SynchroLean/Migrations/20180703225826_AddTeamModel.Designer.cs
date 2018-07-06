﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SynchroLean.Persistence;

namespace SynchroLean.Migrations
{
    [DbContext(typeof(SynchroLeanDbContext))]
    [Migration("20180703225826_AddTeamModel")]
    partial class AddTeamModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("SynchroLean.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OwnerId");

                    b.Property<string>("TeamDescription")
                        .HasMaxLength(250);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("SynchroLean.Models.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CompletionDate");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<bool>("IsCompleted");

                    b.Property<bool>("IsRecurring");

                    b.Property<bool>("IsRemoved");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte>("Weekdays");

                    b.HasKey("Id");

                    b.ToTable("UserTasks");
                });
#pragma warning restore 612, 618
        }
    }
}