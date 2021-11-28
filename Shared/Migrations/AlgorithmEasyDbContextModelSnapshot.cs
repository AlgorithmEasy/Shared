﻿// <auto-generated />
using System;
using AlgorithmEasy.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlgorithmEasy.Shared.Migrations
{
    [DbContext(typeof(AlgorithmEasyDbContext))]
    partial class AlgorithmEasyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.CourseHistory", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(30)");

                    b.Property<short>("CourseId")
                        .HasColumnType("smallint");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseHistory");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Teacher"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Student"
                        });
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.Session", b =>
                {
                    b.Property<Guid>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Ip")
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("LoginTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("SessionId");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasComment("用户名");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("binary(32)")
                        .HasComment("存储SHA256加密后密码");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.CourseHistory", b =>
                {
                    b.HasOne("AlgorithmEasy.Server.Shared.Data.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.Session", b =>
                {
                    b.HasOne("AlgorithmEasy.Server.Shared.Data.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.User", b =>
                {
                    b.HasOne("AlgorithmEasy.Server.Shared.Data.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AlgorithmEasy.Server.Shared.Data.User", b =>
                {
                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
