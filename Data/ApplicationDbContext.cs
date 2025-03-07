using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using E_learning.Models;

namespace E_learning.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedUserRole(builder);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var adminAccount = new IdentityUser
            {
                Id = "user0",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456")
            };

            var studentAccount = new IdentityUser
            {
                Id = "user1",
                UserName = "student@gmail.com",
                Email = "student@gmail.com",
                NormalizedUserName = "STUDENT@GMAIL.COM",
                NormalizedEmail = "STUDENT@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456")
            };

            var teacherAccount = new IdentityUser
            {
                Id = "user2",
                UserName = "teacher@gmail.com",
                Email = "teacher@gmail.com",
                NormalizedUserName = "TEACHER@GMAIL.COM",
                NormalizedEmail = "TEACHER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456")
            };

            var managerAccount = new IdentityUser
            {
                Id = "user3",
                UserName = "manager@gmail.com",
                Email = "manager@gmail.com",
                NormalizedUserName = "MANAGER@GMAIL.COM",
                NormalizedEmail = "MANAGER@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123456")
            };

            builder.Entity<IdentityUser>().HasData(adminAccount, studentAccount, teacherAccount, managerAccount);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "role0", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "role1", Name = "Student", NormalizedName = "STUDENT" },
                new IdentityRole { Id = "role2", Name = "Teacher", NormalizedName = "TEACHER" },
                new IdentityRole { Id = "role3", Name = "Manager", NormalizedName = "MANAGER" }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "user0", RoleId = "role0" },
                new IdentityUserRole<string> { UserId = "user1", RoleId = "role1" },
                new IdentityUserRole<string> { UserId = "user2", RoleId = "role2" },
                new IdentityUserRole<string> { UserId = "user3", RoleId = "role3" }
            );
        }

        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<E_learning.Models.Course> Course { get; set; }
        public DbSet<E_learning.Models.Payment> Payment { get; set; }
        public DbSet<E_learning.Models.Schedule> Schedule { get; set; }
    }
}