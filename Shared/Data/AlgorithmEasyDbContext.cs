using Microsoft.EntityFrameworkCore;

namespace AlgorithmEasy.Shared.Data
{
    public class AlgorithmEasyDbContext : DbContext
    {
        public DbSet<User> Users { get; }
        public DbSet<Role> Roles { get; }
        public DbSet<Session> Sessions { get; }
        public DbSet<Course> Courses { get; }
        public DbSet<LearningHistory> LearningHistories { get; }


        public AlgorithmEasyDbContext(DbContextOptions<AlgorithmEasyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>(entity =>
                {
                    entity.Property(user => user.Id).HasComment("用户名");
                    entity.Property(user => user.Password).HasColumnType("binary(32)").HasComment("存储SHA256加密后密码");
                    entity.HasKey(user => user.Id);
                })
                .Entity<Role>(entity => {
                    entity.Property(role => role.RoleName).HasColumnType("varchar(20)");
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
                    entity.Property(course => course.CourseId).ValueGeneratedOnAdd();
                    entity.HasKey(course => course.CourseId);
                })
                .Entity<LearningHistory>(entity =>
                {
                    entity.HasKey("UserId", "CourseId");
                    entity.HasIndex("UserId");
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
