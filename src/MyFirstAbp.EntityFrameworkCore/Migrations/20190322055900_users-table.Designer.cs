﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstAbp.EntityFrameworkCore;

namespace MyFirstAbp.Migrations
{
    [DbContext(typeof(MyFirstAbpDbContext))]
    [Migration("20190322055900_users-table")]
    partial class userstable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyFirstAbp.Student.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aa");

                    b.Property<string>("bb");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("MyFirstAbp.Tasks.TaskInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AssignePersonId");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(65536);

                    b.Property<byte>("State");

                    b.Property<string>("Title22")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("aa");

                    b.HasKey("Id");

                    b.ToTable("TaskInfo");
                });

            modelBuilder.Entity("MyFirstAbp.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
