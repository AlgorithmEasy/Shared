using Microsoft.EntityFrameworkCore;

namespace AlgorithmEasy.Shared.Models
{
    public class AlgorithmEasyDbContext : DbContext
    {
        public DbSet<User> Users { get; }
        public DbSet<Role> Roles { get; }
        public DbSet<Session> Sessions { get; }
        public DbSet<Course> Courses { get; }
        public DbSet<CourseDetail> CourseDetails { get; }
        public DbSet<LearningHistory> LearningHistories { get; }
        public DbSet<Project> Projects { get; }


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
                    entity.HasOne<CourseDetail>().WithOne()
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
                    entity.HasKey("UserId", "CourseId");
                    entity.HasIndex("UserId", "CourseId");
                })
                .Entity<Project>(entity =>
                {
                    entity.Property(project => project.UpdateTime).ValueGeneratedOnAddOrUpdate();
                    entity.HasKey("UserId", "ProjectName");
                    entity.HasIndex("UserId", "ProjectName");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
