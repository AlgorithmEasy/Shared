﻿// <auto-generated />
using System;
using AlgorithmEasy.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlgorithmEasy.Shared.Migrations
{
    [DbContext(typeof(AlgorithmEasyDbContext))]
    [Migration("20211201054445_UsersAddCreateTime")]
    partial class UsersAddCreateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseDetailTitle")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseDetailTitle");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.CourseDetail", b =>
                {
                    b.Property<string>("Title")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.HasKey("Title");

                    b.ToTable("CourseDetails");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.LearningHistory", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Progress")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId", "CourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId", "CourseId");

                    b.ToTable("LearningHistories");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Project", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ProjectName")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Workspace")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "ProjectName");

                    b.HasIndex("UserId", "ProjectName");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

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

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Session", b =>
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

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasComment("用户名");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("注册时间");

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

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Course", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.CourseDetail", "CourseDetail")
                        .WithMany()
                        .HasForeignKey("CourseDetailTitle");

                    b.Navigation("CourseDetail");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.CourseDetail", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.Course", null)
                        .WithOne()
                        .HasForeignKey("AlgorithmEasy.Shared.Models.CourseDetail", "Title")
                        .HasPrincipalKey("AlgorithmEasy.Shared.Models.Course", "Title")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.LearningHistory", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlgorithmEasy.Shared.Models.User", null)
                        .WithMany("LearningHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Project", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.User", null)
                        .WithMany("Projects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.Session", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.User", b =>
                {
                    b.HasOne("AlgorithmEasy.Shared.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AlgorithmEasy.Shared.Models.User", b =>
                {
                    b.Navigation("LearningHistories");

                    b.Navigation("Projects");

                    b.Navigation("Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
