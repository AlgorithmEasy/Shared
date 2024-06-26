﻿using Microsoft.EntityFrameworkCore;

namespace AlgorithmEasy.Shared.Models
{
    public class AlgorithmEasyDbContext : DbContext
    {
        public DbSet<User> Users { get; init; }
        public DbSet<Role> Roles { get; init; }
        public DbSet<Session> Sessions { get; init; }
        public DbSet<Course> Courses { get; init; }
        public DbSet<CourseDetail> CourseDetails { get; init; }
        public DbSet<LearningHistory> LearningHistories { get; init; }
        public DbSet<Project> Projects { get; init; }


        public AlgorithmEasyDbContext(DbContextOptions<AlgorithmEasyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>(entity =>
                {
                    entity.Property(user => user.UserId).HasComment("用户名");
                    entity.Property(user => user.CreateTime).ValueGeneratedOnAdd().HasComment("注册时间");
                    entity.Property(user => user.Password).HasColumnType("binary(32)").HasComment("存储SHA256加密后密码");
                    entity.HasKey(user => user.UserId);
                })
                .Entity<Role>(entity => {
                    entity.HasKey(role => role.RoleId);
                    entity.HasData(
                            new Role { RoleId = 1, RoleName = "Admin" },
                            new Role { RoleId = 2, RoleName = "Teacher" },
                            new Role { RoleId = 3, RoleName = "Student" }
                    );
                })
                .Entity<Session>(entity =>
                {
                    entity.Property(session => session.LoginTime).ValueGeneratedOnAdd();
                    entity.HasKey(session => session.SessionId);
                })
                .Entity<Course>(entity =>
                {
                    entity.Property<string>("Title").HasColumnType("varchar(30)").ValueGeneratedNever();
                    entity.HasKey(course => course.CourseId);
                    entity.HasOne(course => course.CourseDetail).WithOne()
                        .HasForeignKey<CourseDetail>(courseDetail => courseDetail.Title)
                        .HasPrincipalKey<Course>("Title");
                })
                .Entity<CourseDetail>(entity =>
                {
                    entity.Property(courseDetail => courseDetail.Title).ValueGeneratedNever();
                    entity.Property(courseDetail => courseDetail.UpdateTime).ValueGeneratedOnAddOrUpdate();
                    entity.HasKey(courseDetail => courseDetail.Title);
                })
                .Entity<LearningHistory>(entity =>
                {
                    entity.Property(history => history.UpdateTime).ValueGeneratedOnAddOrUpdate();
                    entity.HasKey(history => new { history.UserId, history.CourseId });
                    entity.HasIndex(history => new { history.UserId, history.CourseId });
                    entity.HasOne<User>().WithMany(user => user.LearningHistories)
                        .HasForeignKey(history => history.UserId);
                    entity.HasOne<Course>().WithMany(course => course.LearningHistories)
                        .HasForeignKey(history => history.CourseId);
                })
                .Entity<Project>(entity =>
                {
                    entity.Property(project => project.UpdateTime).ValueGeneratedOnAddOrUpdate();
                    entity.HasKey(project => new { project.UserId, project.ProjectName });
                    entity.HasIndex(project => new { project.UserId, project.ProjectName });
                    entity.HasOne<User>().WithMany(user => user.Projects)
                        .HasForeignKey(project => project.UserId);
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
